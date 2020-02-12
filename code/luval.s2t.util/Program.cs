using luval.s2t.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luval.s2t.util
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFile = @"C:\Users\ch489gt\Downloads\OTC Automation workshop webex link set up-20200210 1853-3.mp4";
            var ouputFile = @"C:\Users\ch489gt\Downloads\OTC Automation workshop webex link set up-20200210 1853-3.wav";
            var converter = new AudioConverter();
            converter.CreateWavFromMp4(inputFile,ouputFile);
        }
    }
}
