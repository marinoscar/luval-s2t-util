using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.s2t.core
{
    public class AudioConverter
    {
        public void CreateWavFromMp4(string videoFile, string outputAudioFile)
        {
            var file = @"C:\Users\ch489gt\Downloads\OTC Automation workshop webex link set up-20200210 1853-3.mp4";
            using (var video = new MediaFoundationReader(videoFile))
            {
                WaveFileWriter.CreateWaveFile(outputAudioFile, video);
            }
        }
    }
}
