using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace FinalProject
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public Patron Borrower { get; set; }
        public LibraryItem BorrowedItem { get; set; }
        public DateTime DueDate { get; set; }
        
    }
}