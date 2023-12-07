using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Patron
    {
        public string Name { get; set; }
        public int PatronID { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Patron ID: {PatronID}");
        }
    }
}