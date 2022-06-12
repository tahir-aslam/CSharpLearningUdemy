using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<DateTime> dateTime = null;
            DateTime? dateTime = null;

            Console.WriteLine("GetValueOrDefault: " + dateTime.GetValueOrDefault());
            Console.WriteLine("HasValue: " + dateTime.HasValue);
            Console.WriteLine("Value: " + dateTime.Value);

            DateTime? date = new DateTime(2022, 06, 12);
            DateTime date2 = date.GetValueOrDefault();

            //null coalscing operator   
            DateTime? date3 = null;
            DateTime date4 = date3 ?? DateTime.Today;

            Console.ReadKey();

        }
    }
}
