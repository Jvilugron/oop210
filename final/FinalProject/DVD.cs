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
    }
}