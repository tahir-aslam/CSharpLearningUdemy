using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //Linq query operator
            var cheaperBooks = from b in books
                               where b.Price < 100
                               orderby b.Title
                               select b;

            //Linq extension methods
            var cheapBooks = books
                .Where(b => b.Price < 100)
                .OrderBy(b => b.Title)
                .Select(b => b.Title);

            var paging = cheapBooks.Skip(2).Take(5);
        }
    }
}
