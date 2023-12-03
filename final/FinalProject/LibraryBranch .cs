using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class LibraryBranch 
    {
        public string BranchName { get; set; }
        public List<Transaction> Transactions { get; set; }

        public LibraryBranch()
        {
            Transactions = new List<Transaction>();
        }

        public void RegisterPatron(Patron patron)
        {
            Console.WriteLine($"{patron.Name} has been registered at {BranchName} branch.");
        }

        public void ProcessTransactions(Transaction transaction)
        {
            Transactions.Add(transaction);
            Console.WriteLine($"Transaction ID: {transaction.TransactionID} processed at {BranchName} branch");
        }
    }
}