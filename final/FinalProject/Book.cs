using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Book : LibraryItem
    {
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
    }
}