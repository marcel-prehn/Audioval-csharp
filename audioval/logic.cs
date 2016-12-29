using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NAudio.Wave;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace audioval
{
    public static class logic
    {
        private static string WHISTLE = Application.StartupPath + @"\fx\whistle-FX.mp3";
        private static string REST = Application.StartupPath + @"\fx\rest-FX.mp3";
        private static string RUN = Application.StartupPath + @"\fx\run-FX.mp3";
        private static string WORKOUT_COMPLETE = Application.StartupPath + @"\fx\workout_complete-FX.mp3";
        private static string WORKOUT_STARTED = Application.StartupPath + @"\fx\workout_started-FX.mp3";

        public static List<string> addWhistle(List<string> files, int run, int rest, int warmupIndex, int cooldownIndex)
        { 
            if (files.Count != 0)
            {
                int warmup = (warmupIndex * 60);
                int cooldown = (cooldownIndex * 60);
                List<string> filesWhisle = new List<string>();
                // Start Workout
                if (warmup != 0)
                {
                    // Start Warmup
                    for (int i = 0; i < warmup; i++)
                    {
                        filesWhisle.Add(files[i]);
                    }
                    // Finish Warmup
                }
                // Start Interval Training
                filesWhisle.Add(WORKOUT_STARTED);

                int warmupIndexer = warmup;
                int filesOnly = ((files.Count - warmup) - cooldown);
                int warmupCooldown = (run + rest) + 2;
                int diff = filesOnly / warmupCooldown;

                for (int m = 0; m < diff; m++)
                {
                    //l += i;
                    filesWhisle.Add(RUN);
                    for (int j = 0; j < run + 1; j++ )
                    {
                        filesWhisle.Add(files[warmupIndexer]);
                        warmupIndexer++;
                    }

                    filesWhisle.Add(REST);
                    for (int k = 0; k < rest + 1; k++)
                    {
                        filesWhisle.Add(files[warmupIndexer]);
                        warmupIndexer++;
                    } 
                }

                // Finish Interval Training
                filesWhisle.Add(WORKOUT_COMPLETE);

                if (cooldown != 0)
                {
                    // Start Cool Down
                    for (int i = files.Count - cooldown; i < files.Count; i++)
                    {
                        filesWhisle.Add(files[i]);
                    }
                    // Finish Cool Down
                }
                // Finish Workout
                return filesWhisle;
            }
            else
            {
                return null;
            }
        }

        private static string getRunRest(int I)
        {
            if (I % 2 != 0)
            {
                return RUN;
            }
            else
            {
                return REST;
            }
        }

        public static List<string> convertToWav(List<string> sourceFiles)
        {
            List<string> output = new List<string>();
            foreach (string s in sourceFiles)
            {
                using (Mp3FileReader reader = new Mp3FileReader(s))
                {
                    using (WaveStream pcmStream = WaveFormatConversionStream.CreatePcmStream(reader))
                    {
                        WaveFileWriter.CreateWaveFile(s + "-WAV.wav", pcmStream);
                        output.Add(s + "-WAV.wav");
                    }
                }

            }
            return output;
        }

        public static string mergeWav(List<string> sourceFiles, string OutputDir, string Filename)
        {
            byte[] buffer = new byte[1024];
            WaveFileWriter waveFileWriter = null;
            string outputFile = OutputDir + Filename + ".wav";

            foreach (string sourceFile in sourceFiles)
            {
                using (WaveFileReader reader = new WaveFileReader(sourceFile))
                {
                    int read;
                    if (waveFileWriter == null)
                    {
                        waveFileWriter = new WaveFileWriter(outputFile, reader.WaveFormat);
                    }
                    while ((read = reader.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        waveFileWriter.Write(buffer, 0, read);
                    }
                }
            }

            if (waveFileWriter != null)
            {
                waveFileWriter.Dispose();
            }

            return outputFile;
        }

        public static string mergeMp3(List<string> inputFiles, string OutputDir, string Filename)
        {
            string outputFile = OutputDir + @"\" + Filename + ".mp3";
            int index = 0;
            while (File.Exists(outputFile) == true)
            {
                outputFile = OutputDir + @"\" + Filename + "-0" + index++ + ".mp3";
            }
            FileStream output = new FileStream(outputFile, FileMode.CreateNew);           
            foreach (string file in inputFiles)
            {
                Mp3FileReader reader = new Mp3FileReader(file);
                Mp3Frame frame;

                if ((output.Position == 0) && (reader.Id3v2Tag != null))
                {
                    output.Write(reader.Id3v2Tag.RawData, 0, reader.Id3v2Tag.RawData.Length);
                }
                
                while ((frame = reader.ReadNextFrame()) != null)
                {
                    output.Write(frame.RawData, 0, frame.RawData.Length);
                }
                reader.Dispose();
            }
            output.Close();
            output.Dispose();
            return Filename  + ".mp3";
        }

        public static void cleanUp(List<string> sourceFiles)
        {
            foreach (string s in sourceFiles)
            {
                if (s.Contains("-FX") == false)
                {
                    File.Delete(s);
                }
            }
        }

        public static void cleanUp(string s)
        {
            if (s.Contains("-FX") == false)
            {
                File.Delete(s);
            }
        }

        public static void showException(string PointOfException, Exception ex)
        {
            MessageBox.Show("Fehler in der Prozedur " + PointOfException + "\n" + ex.Message.ToString(), "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
