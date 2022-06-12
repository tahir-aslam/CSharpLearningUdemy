using System.Collections.Generic;

namespace LINQ
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){ Title ="ASP .Net", Price=85.5f },
                new Book(){ Title="WPF MVVM", Price=80.5f},
            };
        }
    }
}
