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

        public List<LibraryItem> SearchByTitle(string title)
        {
            List<LibraryItem> results = Items.FindAll(item => item.Title.ToLower().Contains(title.ToLower()));
            return results;
        }

        public void DisplayCatalog()
        {
            foreach (var item in Items)
            {
                item.DisplayDetails();
                Console.WriteLine("------------");
            }
        }

        public void SaveData()
        {
            using (StreamWriter sw = new StreamWriter("library_data.txt"))
            {
                foreach (var item in Items)
                {
                    item.SaveItem(sw);
                    sw.WriteLine("------------");
                }
            }

            Console.WriteLine("Data saved to: library_data.txt");
        }

        public void LoadData(string FinalProject)
        {
            if (File.Exists(FinalProject))
            {
                using (StreamReader sr = new StreamReader(FinalProject))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line == "------------")
                        {
                            string itemType = sr.ReadLine();
                            LibraryItem newItem;

                            if (itemType == "Book")
                            {
                                newItem = ReadBookData(sr);
                            }
                            
                            else if (itemType == "DVD")
                            {
                                newItem = ReadDVDData(sr);
                            }

                            else
                            {
                                Console.WriteLine("No Item Found");
                                continue;
                            }

                            Items.Add(newItem);
                            
                        }
                    }
                }

                Console.WriteLine("Data loaded succesfully");
            }

            else
            {
                Console.WriteLine("File not found or data not available.");
            }   
        }

        private Book ReadBookData(StreamReader sr)
        {
            Book newBook =  new Book();
            newBook.Title = ReadStringValue(sr);
            return newBook;
        }

        private DVD ReadDVDData(StreamReader sr)
        {
            DVD newDVD = new DVD();
            newDVD.Title = ReadStringValue(sr);
            return newDVD;
        }

        private string ReadStringValue(StreamReader sr)
        {
            string value = sr.ReadLine();
            return value.Substring(value.IndexOf(":") + 2);
        }
    }
}