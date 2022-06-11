using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var photoProcessor = new PhotoProcessor();
            var filters = new Photofilters();

            Action<Photo> photoFilterHandler = filters.ApplyBrightness;
            //PhotoProcessor.PhotoFilterHandler photoFilterHandler = filters.ApplyBrightness;
            photoFilterHandler += filters.ApplyContrast;
            photoFilterHandler += filters.Resize;
            photoFilterHandler += RemoveRedEye;

            photoProcessor.Process("photo.png", photoFilterHandler);            

            Console.ReadKey();
        }

        static void RemoveRedEye(Photo photo)
        {
            Console.WriteLine("Remove red eye......");
        }
    }
}
