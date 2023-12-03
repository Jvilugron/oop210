using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class LibraryCatalog 
    {
        public List<LibraryItem> Items { get; set; }

        public LibraryCatalog()
        {
            Items = new List<LibraryItem>();
        }

        public void AddItem(LibraryItem item)
        {
            Items.Add(item);
            Console.WriteLine($"{item.Title} has been added to the catalog.");
        }

        public void RemoveItem(LibraryItem item)
        {
            Items.Remove(item);
            Console.WriteLine($"{item.Title} has been removed from the catalog");
        }
    }
}