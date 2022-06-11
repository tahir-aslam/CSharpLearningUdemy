using System;

namespace Events
{
    partial class Program
    {
        public class MailService 
        {
            public void OnVideoEncoded(object sender, EventArgs e)
            {
                Console.WriteLine("Sending Email....");
            }
        }
    }
}
