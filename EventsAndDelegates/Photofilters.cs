using System;

namespace EventsAndDelegates
{
    public class Photofilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Photofilter: Applying brightness.....");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Photofilter: Applying Contrast.....");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine("Photofilter: Applying resize.....");
        }
    }
}
