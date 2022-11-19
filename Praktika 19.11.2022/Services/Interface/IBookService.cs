using Praktika_19._11._2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_19._11._2022.Services.Interface
{
    public interface IBookService
    {
        int GetCount(Predicate<Book> predicate);
    }
}
