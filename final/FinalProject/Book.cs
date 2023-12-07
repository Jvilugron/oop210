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

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Author: {Author}.");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Genre: {Genre}");
        }

        public override void SaveItem(StreamWriter sw)
        {
            base.SaveItem(sw);
            sw.WriteLine($"Author: {Author}");
            sw.WriteLine($"ISBN: {ISBN}");
            sw.WriteLine($"Genre: {Genre}");
        }
    }
}