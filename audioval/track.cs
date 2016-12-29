using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NAudio.Wave;
using System.IO;
using System.Windows.Forms;

namespace audioval
{
    public class track
    {
        public string filename { get; set; }
        public string output { get; set; }
        public List<string> files = new List<string>();
        
        public track()
        {
            //files = new List<string>();
        }

        public void splitWav(string input)
        {
            int offset = 0;
            int split = 5000;
            int index = 0;
            string fileSplit;
            byte[] buffer = new byte[1024];
            using (var reader = new AudioFileReader(input))
            {
                FileStream writer = null;
                Action createWriter = new Action(() =>
                {
                    fileSplit = input + "-" + ++index + ".mp3";
                    //files.Add(fileSplit);
                    writer = File.Create(fileSplit);
                });
                while (reader.Position != buffer.Length)
                {
                    if (writer == null)
                    {
                        createWriter();
                    }
                    if ((int)reader.CurrentTime.TotalMilliseconds - offset >= split)
                    {
                        writer.Dispose();
                        createWriter();
                        offset = (int)reader.CurrentTime.TotalMilliseconds;
                    }
                    writer.Write(buffer, 0, buffer.Length);
                }
                if (writer != null)
                {
                    writer.Dispose();
                }
            }
            //string lastFile = files[files.Count - 1];
        }

        public List<string> splitMp3()
        {
            int offset = 0;
            int split = 5000;
            int index = 0;
            string fileSplit;
            using (var reader = new Mp3FileReader(output + filename))
            {
                FileStream writer = null;
                Action createWriter = new Action(() =>
                {
                    fileSplit = output + filename + "-" + ++index + ".mp3";
                    files.Add(fileSplit);
                    writer = File.Create(fileSplit);
                });
                Mp3Frame frame;
                while ((frame = reader.ReadNextFrame()) != null)
                {
                    if (writer == null)
                    {
                        createWriter();
                    }
                    if ((int)reader.CurrentTime.TotalMilliseconds - offset >= split)
                    {
                        writer.Dispose();
                        createWriter();
                        offset = (int)reader.CurrentTime.TotalMilliseconds;
                    }
                    writer.Write(frame.RawData, 0, frame.RawData.Length);
                }
                if (writer != null)
                {
                    writer.Dispose();
                }
            }
            string lastFile = files[files.Count - 1];
            files.RemoveAt(files.Count - 1);
            File.Delete(lastFile);
            return files;
        }

        public void clear()
        {
            foreach (string s in files)
            {
                if(s.Contains("-FX") == false)
                {
                    File.Delete(s);
                }
            }
            File.Delete(this.output + this.filename);
        }

        public string toWav(string file)
        {
            using (Mp3FileReader reader = new Mp3FileReader(file))
            {
                using (WaveStream pcmStream = WaveFormatConversionStream.CreatePcmStream(reader))
                {
                    WaveFileWriter.CreateWaveFile(file + "-WAV.wav", pcmStream);
                }
            }
            return file + "-WAV.wav";
        }
    }
}
