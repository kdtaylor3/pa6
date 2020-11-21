using System;
using System.IO;

namespace pa5_kdtaylor3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Welcome to the Audio Book Library";
            Book[] myBook = new Book[500];
            Transaction[] myTransaction = new Transaction[500];
            string userChoice = " ";
            while (userChoice != "7")
            {
                //menu
                Console.WriteLine("Welcome to this audioBook Library ");
                Console.WriteLine("Enter 1 to list all of book");
                Console.WriteLine("Enter 2 to add a book ");
                Console.WriteLine("Enter 3 to edit Books");
                Console.WriteLine("Enter 4 to rent a copy of a book");
                Console.WriteLine("Enter 5 to return a book");
                Console.WriteLine("Enter 6 to run reports");
                Console.WriteLine("Enter 7 to exit this program  ");
                userChoice = Console.ReadLine();
                Console.Clear();

                Transaction[] myArray = null;
                //switch
                switch (userChoice)
                {
                    case "1":
                        Book[] myBooks = ReadIn(myBook);

                        for (int i = 0; i < Book.GetCount(); i++)
                        {
                            Console.WriteLine(myBooks[i].ToString());
                        }

                        break;

                    case "2":
                        BookUtilities.AddBook(myBook);
                        break;

                    case "3":
                        BookUtilities.EditBook(myBook);
                        break;

                    case "4":
                        TransactionUtilities.RentBook(myBook, myTransaction);
                        break;

                    case "5":
                        TransactionUtilities.ReturnBook(myBook, myTransaction);
                        break;

                    case "6":
                        Report.RunReports(myBook, myTransaction, myArray);
                        break;

                    case "7":
                        break;

                    default:
                        break;

                }
            }
        }
        static Book[] ReadIn(Book[] myBook)
        {
            Book.SetCount(0);
            Transaction.SetCount(0);
            // read file
            StreamReader inFile = new StreamReader("books.txt");

            string tempFileInput = " ";

            const char delimiter = '#';

            string[] tempArray = new string[6];

            if (File.Exists("books.txt"))
            {
                tempFileInput = inFile.ReadLine();

                while (tempFileInput != null)
                {
                    tempArray = tempFileInput.Split(delimiter);

                    myBook[Book.GetCount()] = new Book(tempArray[0], tempArray[1], tempArray[2], tempArray[3], int.Parse(tempArray[4]), int.Parse(tempArray[5]));

                    Book.IncCount();

                    tempFileInput = inFile.ReadLine();
                }
            }
            return myBook;
        }

    }
}
