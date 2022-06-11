using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "myVideo" };

            var videoEncoder = new VideoEncoder();

            var mailService = new MailService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;

            videoEncoder.Encode(video);

            Console.Read();
        }      

        public class VideoEncoder
        {
            public delegate void VideoEncodedEventHandler(object sender, EventArgs e);
            public event VideoEncodedEventHandler VideoEncoded;

            public void Encode(Video video)
            {
                Console.WriteLine("Encoding....");
                Thread.Sleep(3000);
                OnVideoEncoded();
            }

            protected virtual void OnVideoEncoded()
            {
                if (VideoEncoded != null)
                    VideoEncoded(this, EventArgs.Empty);
            }
        }

        public class Video
        {
            public string Title { get; set; }
        }

        public class MailService 
        {
            public void OnVideoEncoded(object sender, EventArgs e)
            {
                Console.WriteLine("Sending Email....");
            }
        }
    }
}
