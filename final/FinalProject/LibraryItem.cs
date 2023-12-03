using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class LibraryItem
    {
        public string Title { get; set; }
        public int ItemID {get; set; }
        public bool Available {get; set; }

        public virtual void CheckOut()
        {
            Available = false; 
            Console.WriteLine($"{Title} has been checked out.");
        }

        public virtual void ReturnItem()
        {
            Available = true; 
            Console.WriteLine($"{Title} has been returned.");
        }
    }
}