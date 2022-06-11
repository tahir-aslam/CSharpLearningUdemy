using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "myVideo" };

            var videoEncoder = new VideoEncoder(); //publisher

            var mailService = new MailService(); //subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            videoEncoder.Encode(video);

            Console.Read();
        }      
    }
}
