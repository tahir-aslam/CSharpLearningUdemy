using System;
using System.Threading;

namespace Events
{
    partial class Program
    {
        public class VideoEncoder
        {
            //public delegate void VideoEncodedEventHandler(object sender, EventArgs e);
            //public event VideoEncodedEventHandler VideoEncoded;

            //EventHandler
            public event EventHandler<EventArgs> VideoEncoded;

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
    }
}
