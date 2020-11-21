using System;
using System.IO;

namespace pa5_kdtaylor3
{
    public class Transaction
    {
        private int rentalID;
        private int ISBN;
        private string customerName;
        private string customerEmail;
        private int rentalDate;
        private int returnDate;
        static private int count;
    

        public Transaction()
        {
            
        }
        public Transaction(int tempRentalID, int tempISBN, string tempCustomerName, string tempCustomerEmail, int tempRentalDate, int tempReturnDate)
        {
            rentalID = tempRentalID;
            ISBN = tempISBN;
            customerName = tempCustomerName;
            customerEmail = tempCustomerEmail;
            rentalDate = tempRentalDate;
            returnDate = tempReturnDate;
        }

        public int GetRentalID()
        {
            return rentalID;
        }
        public void SetRentalID(int tempRentalID)
        {
            ISBN = tempRentalID;
        }

        public int GetISBN()
        {
            return ISBN;
        }
        public void SetISBN(int tempISBN)
        {
            ISBN = tempISBN;
        }

        public string GetCustomerName()
        {
            return customerName;
        }
        public void SetCustomerName(string tempCustomerName)
        {
            customerName = tempCustomerName;
        }

        public string GetCustomerEmail()
        {
            return customerEmail;
        }
        public void SetCustomerEmail(string tempCustomerEmail)
        {
            customerEmail = tempCustomerEmail;
        }

        public int GetRentalDate()
        {
            return rentalDate;
        }
        public void SetRentalDate(int tempRentalDate)
        {
            rentalDate = tempRentalDate;
        }

        public int GetReturnDate()
        {
            return returnDate;
        }
        public void SetReturnDate(int tempReturnDate)
        {
            returnDate = tempReturnDate;
        }

        public int CompareTo(Transaction myArray){
            return ISBN.CompareTo(myArray.GetISBN());
        }

        public void SetMonth(int tempRentalDate)
        {
            rentalDate = tempRentalDate;
        }

        public int GetMonth()
        {
            return rentalDate;
        }
         public void SetYear(int tempRentalDate)
        {
            rentalDate = tempRentalDate;
        }
         public int GetYear()
        {
            return rentalDate;
        }


        
        public void SetValues(int tempRentalID, int tempISBN, string tempCustomerName, string tempCustomerEmail, int tempRentalDate, int tempReturnDate)
        {
            rentalID = tempRentalID;
            ISBN = tempISBN;
            customerName = tempCustomerName;
            customerEmail = tempCustomerEmail;
            rentalDate = tempRentalDate;
            returnDate = tempReturnDate;
        }

        static public int GetCount()
        {
            return count;
        }

        static public void SetCount(int tempCount)
        {
            count = tempCount;
        }

        static public void IncCount()
        {
            count++;
        }

        public new string ToString()
        {
            return rentalID + " " + ISBN + " " + customerName + " " + customerEmail + " " + rentalDate + " " + returnDate;
        }


        static public void PrintAllTransactions(Transaction[] myArray)
        {
            for (int i = 0; i < Book.GetCount(); i++)
            {
                Console.WriteLine("rentalID: {0}, ISBN: {1}, customerName: {2}, customerEmail: {3}, rentalDate: {4}, returnDate: {5}",
                                  myArray[i].GetRentalID(), myArray[i].GetISBN(), myArray[i].GetCustomerName(), myArray[i].GetCustomerEmail(), myArray[i].GetRentalDate(), myArray[i].GetReturnDate());
            }

        }


        static public void SortAllTransaction(Transaction[] myArray)
        {
            int minIndex;

            for (int i = 0; i < count - 1; i++)
            {
                minIndex = i;

                for (int j = i + 1; j < count; j++)
                {
                    if (myArray[j].GetRentalID().CompareTo(myArray[minIndex].GetRentalID()) < 0 ||
                        (myArray[j].GetRentalID().CompareTo(myArray[minIndex].GetRentalID()) == 0 && myArray[j].GetReturnDate() < myArray[minIndex].GetReturnDate()))
                        minIndex = j;
                }

                if (minIndex != i)
                {
                    Transaction.SwapArray(myArray, i, minIndex);
                }

            }

        }

        static public void SwapArray(Transaction[] myArray, int i1, int i2)
        {
            Transaction tempTransaction = new Transaction(myArray[i1].GetRentalID(), myArray[i1].GetISBN(), myArray[i1].GetCustomerName(), myArray[i1].GetCustomerEmail(), myArray[i1].GetRentalDate(), myArray[i1].GetReturnDate());

            myArray[i1].SetRentalID(myArray[i2].GetRentalID());
            myArray[i1].SetISBN(myArray[i2].GetISBN());
            myArray[i1].SetCustomerName(myArray[i2].GetCustomerName());
            myArray[i1].SetCustomerEmail(myArray[i2].GetCustomerEmail());
            myArray[i1].SetRentalDate(myArray[i2].GetRentalDate());
            myArray[i1].SetReturnDate(myArray[i2].GetReturnDate());


            myArray[i2].SetRentalID(tempTransaction.GetRentalID());
            myArray[i2].SetISBN(tempTransaction.GetISBN());
            myArray[i2].SetCustomerName(tempTransaction.GetCustomerName());
            myArray[i2].SetCustomerEmail(tempTransaction.GetCustomerEmail());
            myArray[i2].SetRentalDate(tempTransaction.GetRentalDate());
            myArray[i2].SetReturnDate(tempTransaction.GetReturnDate());

        }
        static public int FindCustomerEmail(Transaction[] myTransaction, string customerEmailToFind)
        {
            int beginIndex = 0, endIndex = Transaction.GetCount() - 1;
            int indexToFind = -1;
            bool customerNotFound = true;

            int midIndex = (beginIndex + endIndex) / 2;


            if (myTransaction[midIndex].GetCustomerEmail() == customerEmailToFind)
            {
                customerNotFound = false;
                indexToFind = midIndex;
            }

            while (customerNotFound && beginIndex <= endIndex)
            {
                if (myTransaction[midIndex].GetISBN().CompareTo(customerEmailToFind) > 0)
                {
                    endIndex = midIndex - 1;
                }
                else if (myTransaction[midIndex].GetISBN().CompareTo(customerEmailToFind) < 0)
                {
                    beginIndex = midIndex + 1;
                }
                else
                {
                    customerNotFound = false;
                    indexToFind = midIndex;
                }

                midIndex = (beginIndex + endIndex) / 2;
            }
            return indexToFind;
        }
        static public int FindISBN(Book[] myBooks, string isbnToFind)
        {
            int beginIndex = 0, endIndex = Book.GetCount() - 1;
            int indexToFind = -1;
            bool BookNotFound = true;

            int midIndex = (beginIndex + endIndex) / 2;


            if (myBooks[midIndex].GetISBN() == isbnToFind)
            {
                BookNotFound = false;
                indexToFind = midIndex;
            }

            while (BookNotFound && beginIndex <= endIndex)
            {
                if (myBooks[midIndex].GetISBN().CompareTo(isbnToFind) > 0)
                {
                    endIndex = midIndex - 1;
                }
                else if (myBooks[midIndex].GetISBN().CompareTo(isbnToFind) < 0)
                {
                    beginIndex = midIndex + 1;
                }
                else
                {
                    BookNotFound = false;
                    indexToFind = midIndex;
                }

                midIndex = (beginIndex + endIndex) / 2;
            }
            return indexToFind;
        }

        static public void WriteAllTransactions(Transaction[] myArray)
            {
                StreamWriter outFile = new StreamWriter("Transaction.txt", true);

                for (int i = 0; i < Transaction.GetCount(); i++)
                {
                    outFile.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}",
                        myArray[i].GetRentalID(),
                        myArray[i].GetISBN(),
                        myArray[i].GetCustomerName(),
                        myArray[i].GetCustomerEmail(),
                        myArray[i].GetRentalDate(),
                        myArray[i].GetReturnDate());
                }

                outFile.Close();

            }
        static public void customerRentalDate(Transaction[] myArray)
        {
            DateTime today = DateTime.Today;
            string myDate = today.ToString("MM/DD/YYYY");
            Console.WriteLine(myDate);
            Console.ReadKey();

        }
        static public void customerReturnDate(Transaction[] myArray)
        {
            DateTime today = DateTime.Today;
            string myDate = today.ToString("MM/DD/YYYY");
            Console.WriteLine(myDate);
            Console.ReadKey();
        }

    
    }
}