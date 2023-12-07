using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class DVD : LibraryItem
    {
        public string Director { get; set; }
        public int Duration { get; set; }
        public int ReleaseYear { get; set; }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Director: {Director}");
            Console.WriteLine($"Duration: {Duration} Minutes");
            Console.WriteLine($"Release year: {ReleaseYear}");
        }

        public override void SaveItem(StreamWriter sw)
        {
            base.SaveItem(sw);
            Console.WriteLine($"Director: {Director}");
            Console.WriteLine($"Duration: {Duration} Minutes");
            Console.WriteLine($"Release year: {ReleaseYear}");
        }
    }
}