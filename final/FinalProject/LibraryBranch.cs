using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject
{
    public class LibraryBranch 
    {
        public string BranchName { get; set; }
        public List<Patron> Patrons {get; set; }
        public List<Transaction> Transactions { get; set; }

        public LibraryBranch()
        {
            Transactions = new List<Transaction>();
        }

        public Patron GetPatronByName(string name)
        {
            if (Patrons != null && Patrons.Any())
            {
                return Patrons.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            }

            return null;
            
        }

        public int GeneratePatronID()
        {
            int maxID = Patrons.Any() ? Patrons.Max(p => p.PatronID) : 0;
            return maxID + 1;
        }

        public void RegisterPatron(Patron patron)
        {
            Patrons.Add(patron);
        }

        public void ProcessTransactions(Transaction transaction)
        {
            Transactions.Add(transaction);
            
        }
    }
}