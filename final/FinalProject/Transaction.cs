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

        public void DisplayDetails()
        {
            Console.WriteLine($"Transaction ID: {TransactionID}");
            Console.WriteLine($"Borrower: {Borrower.Name}");
            Console.WriteLine($"Borrowed Item: {BorrowedItem.Title}");
            Console.WriteLine($"Due Date: {DueDate}");
        }
    }
}