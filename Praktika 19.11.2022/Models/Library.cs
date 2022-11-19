using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika_19._11._2022.Models
{
    public class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Book[]? _books { get; set; }

        public Library(int size = 100)
        {
            _books = new Book[size];
        }

        public Book this[int id]
        {
            get
            {
                return _books[id];
            }
            set
            {
                _books[id] = value;
            }
        }

    }
}
