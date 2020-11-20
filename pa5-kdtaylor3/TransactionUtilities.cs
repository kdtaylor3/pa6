using System;

namespace pa5_kdtaylor3
{
    public class TransactionUtilities
    {
       public static void RentBook(Book[] myBook, Transaction[] myTransaction)
        {
            Boolean flagToExit = false;

            Console.Write("Enter customer's Email (enter Quit to exit): ");
            int foundIndex = -1;
            string customerEmail = Console.ReadLine();

            if (customerEmail == "Quit")
            {
                flagToExit = true;
            }
            else if (foundIndex == -1)
            {
                foundIndex = Transaction.FindCustomerEmail(myTransaction, customerEmail);
                Console.Write("Enter customer Name: ");
                myTransaction[foundIndex].SetCustomerName(Console.ReadLine());

                Console.Write("Enter Customer's Email: ");
                myTransaction[foundIndex].SetCustomerEmail(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Enter book's isbn: ");
                string isbn = Console.ReadLine();
                int foundIndex1 = -1;

                while (flagToExit != true)
                {


                    if (foundIndex1 == -1)
                    {
                        Console.WriteLine("That book is not available, please try again.");
                    }
                    else
                    {
                        Console.WriteLine("Congrats you have received" + myBook[foundIndex1].GetISBN(), myBook[foundIndex1].GetTitle());


                        //update 

                    }

                    Console.Write("\nEnter book's ISBN (enter Quit to exit): ");
                    customerEmail = Console.ReadLine();


                    if (customerEmail == "Quit")
                    {
                        flagToExit = true;
                    }
                    else
                    {
                    //   foundIndex1 = Book.FindISBN(myBook.GetISBN());
                    }
                }
                Transaction.WriteAllTransactions(myTransaction);
               
            }
            //prints
            Book.WriteAllBooks(myBook );

            Transaction.WriteAllTransactions(myTransaction);

            Book.PrintAllBooks(myBook);

            Book.SortAllBook(myBook);

            Console.WriteLine();

            Book.PrintAllBooks(myBook);

            Console.WriteLine();

        }

        public static void ReturnBook(Book[] myBook, Transaction[] myTransaction)
        {

            Boolean flagToExit = false;
            Console.Write("Enter Email (enter Quit to exit): ");

            string customerEmail = Console.ReadLine();
            int foundIndex = -1;

            if (customerEmail == "Quit")
            {
                flagToExit = true;
            }
            else
            {
                foundIndex = Transaction.FindCustomerEmail(myTransaction, customerEmail);
            }

            while (flagToExit != true)
            {


                if (foundIndex == -1)
                {
                    Console.WriteLine("That book is not available, please try again.");
                }
                else
                {
                    Console.WriteLine("Congrats you have return" + myBook[foundIndex].GetISBN() + " "+ myBook[foundIndex].GetTitle());


                    //update 

                }

                Console.Write("\nEnter book's ISBN (enter Quit to exit): ");
                customerEmail = Console.ReadLine();


                if (customerEmail == "Quit")
                {
                    flagToExit = true;
                }
                else
                {
                   // foundIndex = Book.FindISBN(myBook.GetISBN());
                }
            }
            //prints
            Transaction.WriteAllTransactions(myTransaction);

            Transaction.IncCount();
        }
 
    }
}