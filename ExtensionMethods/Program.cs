using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "I am thankfull to you for your services";
            var shortenPost = post.Shorten(5);
            Console.WriteLine(post);
            Console.WriteLine(shortenPost+" ...");

            Console.ReadKey();
        }
    }
}
