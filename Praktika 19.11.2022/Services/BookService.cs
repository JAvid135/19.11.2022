using Praktika_19._11._2022.Models;
using Praktika_19._11._2022.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_19._11._2022.Services
{
    public class BookService : IBookService
    {
        public int GetCount(Predicate<Book> predicate)
        {
            var books = GetAll();
            return books.FindAll(predicate).Count;
        }
        private List<Book> GetAll()
        {
            List<Book> books = new();

            Book book1 = new()
            {
            Name = "Iskendername",
            Author = "Nizami"
            };

            Book book2 = new()
            {
                Name = "Sikayetname",
                Author = "Fizuli"
            };

            Book book3 = new()
            {
                Name = "Xosrov ve Sirin",
                Author = "Nizami"
            };

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);

            return books;

        }
    }
}
