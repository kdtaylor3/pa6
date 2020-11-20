using System;
using System.IO;

namespace pa5_kdtaylor3
{
    public class BookUtilities
    {
            //input new book
        public static void AddBook(Book[] myBook)
        {
            Boolean flagToExit = false;
            Console.Write("Enter Book ISBN (enter Quit to exit): ");

            string isbn = Console.ReadLine();
            int foundIndex = -1;

            if (isbn == "Quit")
            {
                flagToExit = true;
            }
            else
            {
                foundIndex = Book.FindISBN(myBook, isbn);
            }

            while (flagToExit != true)
            {


                if (foundIndex == -1)
                {
                    myBook[Book.GetCount()] = new Book();
                    myBook[Book.GetCount()].SetISBN(isbn);

                    Console.Write("Enter Book's title: ");
                    myBook[Book.GetCount()].SetTitle(Console.ReadLine());

                    Console.Write("Enter Book's Author: ");
                    myBook[Book.GetCount()].SetAuthor(Console.ReadLine());

                    Console.Write("Enter Book's genre: ");
                    myBook[Book.GetCount()].SetGenre(Console.ReadLine());

                    Console.Write("Enter Book's listening time: ");
                    myBook[Book.GetCount()].SetTotalListeningTime(int.Parse(Console.ReadLine()));

                    Console.Write("Enter Book's copies: ");
                    myBook[Book.GetCount()].SetCopies(int.Parse(Console.ReadLine()));

                    Book.IncCount();
                }
                else
                {
                    myBook[foundIndex].IncCopies();
                    Book.IncCount();
                }

                Console.Write("\nEnter book's ISBN (enter Quit to exit): ");
                isbn = Console.ReadLine();


                if (isbn == "Quit")
                {
                    flagToExit = true;
                }
                else
                {
                    foundIndex = Book.FindISBN(myBook, isbn);
                }
            }
            // write out new book
            Book.WriteAllBooks(myBook);
            // print list 
            Book.PrintAllBooks(myBook);
            //sort 
            Book.SortAllBook(myBook);

            Console.WriteLine();
            //print again 
            Book.PrintAllBooks(myBook);

            Console.WriteLine();
        }
         public static void EditBook(Book[] myBook)
        {
            Boolean flagToExit = false;
            Console.Write("Enter Book ISBN of book to edit (enter Quit to exit): ");

            string isbn = Console.ReadLine();
            int foundIndex = -1;

            if (isbn == "Quit")
            {
                flagToExit = true;
            }
            else
            {
                foundIndex = Book.FindISBN(myBook, isbn);
            }

            while (flagToExit != true)
            {


                if (foundIndex == -1)
                {
                    Console.WriteLine("Book does not exist");
                }
                else
                {
                    Console.Write("Enter Book's title: ");
                    myBook[foundIndex].SetTitle(Console.ReadLine());

                    Console.Write("Enter Book's Author: ");
                    myBook[foundIndex].SetAuthor(Console.ReadLine());

                    Console.Write("Enter Book's genre: ");
                    myBook[foundIndex].SetGenre(Console.ReadLine());

                    Console.Write("Enter Book's listening time: ");
                    myBook[foundIndex].SetTotalListeningTime(int.Parse(Console.ReadLine()));

                    Console.Write("Enter Book's copies: ");
                    myBook[foundIndex].SetCopies(int.Parse(Console.ReadLine()));


                }

                Console.Write("\nEnter book ISBN to edit another book (enter Quit to exit): ");
                isbn = Console.ReadLine();


                if (isbn == "Quit")
                {
                    flagToExit = true;
                }
                else
                {
                    foundIndex = Book.FindISBN(myBook, isbn);
                }
            }
            //prints
            Book.WriteAllBooks(myBook);

            Book.PrintAllBooks(myBook);

            Book.SortAllBook(myBook);

            Console.WriteLine();

            Book.PrintAllBooks(myBook);

            Console.WriteLine();
        }
    }
}