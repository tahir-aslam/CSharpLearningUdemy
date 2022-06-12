using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamics
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "Tahir";
            var hashCode = obj.GetHashCode();
            var type = obj.GetType();

            //var excelObject = "Aslam";
            dynamic excelObject = "Aslam";
            excelObject.Optimize();

            dynamic name = "Tahir"; //string
            name = 10; // int

            Console.Read();
        }
    }
}
