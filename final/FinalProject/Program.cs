using System;
using System.Dynamic;
using FinalProject;

class Program
{
    static LibraryCatalog catalog = new LibraryCatalog();
    static LibraryBranch branch = new LibraryBranch();

    static void Main(string[] args)
    {
        bool exit = false;
        do
        {
            Console.WriteLine("Welcome to the Library Management! What would you like to do? ");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. Add DVD");
            Console.WriteLine("3. Register Patron");
            Console.WriteLine("4. Check Out item");
            Console.WriteLine("5. Return item");
            Console.WriteLine("6. Search Item by title: ");
            Console.WriteLine("7. Display Catalog: ");
            Console.WriteLine("8. Save");
            Console.WriteLine("9. Exit");
            Console.Write("Enter your Choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        AddBook();
                        break;
                    case 2:
                        AddDVD();
                        break;
                    case 3:
                        RegisterPatron();
                        break;
                    case 4:
                        CheckOutItem();
                        break;
                    case 5:
                        ReturnItem();
                        break; 
                    case 6:
                        SearchByTitle();
                        break;
                    case 7:
                        DisplayCatalog();
                        break;
                    case 8:
                        catalog.SaveData();
                        break;
                    case 9:
                        exit = true;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice, please make a valid choice.");
                        break;

                }
            }

            else
            {
                Console.WriteLine("Invalid Input. Please Enter a Number.");
            }

            Console.WriteLine();
        } while (!exit);

    }

    static void AddBook()
    {
        Console.Write("Enter Book Title: ");
        string title = Console.ReadLine();
        Console.Write("Enter Author: ");
        string author = Console.ReadLine();
        Console.Write("Enter ISBN: ");
        string isbn = Console.ReadLine();
        Console.Write("Enter Genre: ");
        string genre = Console.ReadLine();

        Book newBook = new Book
        {
            Title = title,
            Author = author, 
            ISBN = isbn,
            Genre = genre, 
            ItemID = catalog.Items.Count + 1,
            Available = true
        };

        catalog.AddItem(newBook);
    }

    static void AddDVD()
    {
        Console.Write("Enter DVD Title: ");
        string title = Console.ReadLine();
        Console.Write("Enter Director: ");
        string director = Console.ReadLine();
        Console.Write("Enter Duration (In minutes): ");
        int duration = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Release Year: ");
        int releaseYear = Convert.ToInt32(Console.ReadLine());

        DVD newDVD = new DVD
        {
            Title = title,
            Director = director,
            Duration = duration,
            ReleaseYear = releaseYear,
            ItemID = catalog.Items.Count + 1,
            Available = true
        };

        catalog.AddItem(newDVD);
    }

    static void RegisterPatron()
    {
        Console.Write("Enter Patron name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Patron ID: ");
        int patronID = Convert.ToInt32(Console.ReadLine());

        Patron newPatron = new Patron
        {
            Name = name,
            PatronID = patronID,
        };

        branch.RegisterPatron(newPatron);
    }

    static void CheckOutItem()
    {
        Console.Write("Enter the title of the item to check out: ");
        string title = Console.ReadLine();

        LibraryItem item = catalog.SearchByTitle(title)?.FirstOrDefault(i => i.Available);

        if (item != null)
        {
            if (item.Available)
            {
                item.CheckOut();
                Console.WriteLine($"{item.Title} has been checked out.");
            }
            else
            {
                Console.WriteLine($"{item.Title} is not available for check out.");
            }
        }
        else
        {
            Console.WriteLine("Item not found.");
        }
    }

    static void ReturnItem()
    {
        Console.Write("Enter the title of the item to return: ");
        string title = Console.ReadLine();

        LibraryItem item = catalog.SearchByTitle(title)?.FirstOrDefault();

        if (item != null && !item.Available)
        {
            item.ReturnItem();
            Console.WriteLine($"{item.Title} has been returned.");
        }
        else if (item != null && item.Available)
        {
            Console.WriteLine($"{item.Title} is already available.");
        }
        else
        {
            Console.WriteLine("Item not found.");
        }
    }

    static void SearchByTitle()
    {
        Console.Write("Enter the title to search: ");
        string searchTerm = Console.ReadLine();

        List<LibraryItem> searchResults = catalog.SearchByTitle(searchTerm);

        if (searchResults.Count > 0)
        {
            Console.WriteLine($"Found {searchResults.Count} item(s) matching '{searchTerm}':");
            foreach (var item in searchResults)
            {
                item.DisplayDetails();
                Console.WriteLine("------------");
            }
        }

        else
        {
            Console.WriteLine($"No items found matching '{searchTerm}'.");
        }
    }

    static void DisplayCatalog()
    {
        Console.WriteLine("Library Catalog:");
        catalog.DisplayCatalog();
    }
}