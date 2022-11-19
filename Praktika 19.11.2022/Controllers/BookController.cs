using Praktika_19._11._2022.Services;
using Praktika_19._11._2022.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_19._11._2022.Controllers
{
    public class BookController
    {
        public static void GetCount()
        {
            IBookService bookService = new BookService();
            Console.WriteLine(bookService.GetCount(m=>m.Author == "Nizami"));
        }
    }
}
