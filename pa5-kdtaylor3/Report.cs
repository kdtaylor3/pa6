using System;
using System.IO;

namespace pa5_kdtaylor3
{
    public class Report
    {
            // total rentals by month and by year
            // individual         
            //historical customer rental
             //Report method
        public static void RunReports(Book[] myBook, Transaction[] transactions)
        {
            //menu to do different options with the reports
            Console.WriteLine("Press 1 to view total rentals by month and by year");
            Console.WriteLine("Press 2 to view Individual Customer Rentals");
            Console.WriteLine("Press 3 to view Historical Customer Rentals");

            string inputString = Console.ReadLine();
            int reportChoice = int.Parse(inputString);

            //error handeling
            while (reportChoice != 1 && reportChoice != 2 && reportChoice != 3)
            {
                Console.WriteLine("Sorry wrong input!");
                Console.WriteLine("Press 1 to view total rentals by month and by year");
                Console.WriteLine("Press 2 to view Individual Customer Rentals");
                Console.WriteLine("Press 3 to view Historical Customer Rentals");
                inputString = Console.ReadLine();
                reportChoice = int.Parse(inputString);
            }

            //calling the method
           
                if (reportChoice == 1)
                {
                    
                }
                else if (reportChoice == 2)
                {
                    findPreviousRentals(transactions);
                }
                else 
                {
                    historicalRental();
                }
        }

        //Individual Customer Rentals
        public static void findPreviousRentals(Transaction[] transactions)
        {
            Console.WriteLine("Please provide your email address");
            string inputString = Console.ReadLine();
            string ownersEmail = (inputString);
            // int y = 0; //y counts the new transcation array

            //if statement, make sure it exists
            StreamReader tr = new StreamReader("transactions.txt"); //opens the file named transcations.txt

            //delimiter
            int x = 0;
            while (tr.Peek() != -1) //the method will return -1 when it reaches end of file
            {
                string fileInput = tr.ReadLine();
                char delimiter = '#';
                string[] myArray = fileInput.Split(delimiter); //split by delimiter 
                Transaction newTranscation = new Transaction(int.Parse(myArray[0]),int.Parse(myArray[1]), myArray[2], myArray[3], int.Parse(myArray[4]), int.Parse(myArray[5])); //save into a new object
                transactions[x] = newTranscation; //save into the array
                x++; //increase count
            }

            Transaction[] transcations1 = new Transaction[x];

            for (int z = 0; z < x; z++) // z is counting the whole transcation array
            {
                if (inputString == transcations1[z].GetCustomerEmail())
                {
                    //look at the new Transcation array and find spot 0 to start off with
                    Transaction newTr = transcations1[z];
                }
                //showing attributes of the object
                Console.WriteLine(" \r\n Customer Email: " + transcations1[z].GetCustomerEmail() + " Customer Name: " + transcations1[z].GetCustomerName() + " Rental Date: " + transcations1[z].GetRentalDate() + " Renturn Date: " + transcations1[z].GetReturnDate()); //writing it out to the customer
            }

            Console.WriteLine("Would you like to save this report to a file? Yes or No.");
            string userInput = Console.ReadLine();

            if (userInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase)) //when user says yes
            {
                Console.WriteLine("What would you like to name the file?");
                string userChoice = Console.ReadLine();

                StreamWriter report = new StreamWriter(userChoice); //writes to the file

                for (int z = 0; z < x; z++) // z is counting the whole transcation array
                {
                    if (inputString == transactions[z].GetCustomerEmail())
                    {
                        //look at the new Transcation array and find spot 0 to start off with
                        Transaction newTr = transactions[z];
                    }

                    report.WriteLine(transactions[z].GetCustomerEmail() + transactions[z].GetCustomerName() + transactions[z].GetRentalDate() + transactions[z].GetReturnDate()); //writing it out to the file they want to save
                }

                report.Close(); //close the file
            }
        }

              //Historical Customer Rentals
        public static void historicalRental()
        {
            int count;

            Transaction[] transactionArray = new Transaction[500]; //save into an array with 500 spots
            count = populateTransaction(transactionArray);
            sortArray(transactionArray, count); //passed in transcationArray and count into sortArray

            for (int z = 0; z < count; z++) // z is counting the whole transcation array
            {
                //showing attributes of the object
                Console.WriteLine(" \r\n Customer Email: " + transactionArray[z].GetCustomerEmail() + " Renters Name: " + transactionArray[z].GetCustomerName() + " Rental Date: " + 
                    transactionArray[z].GetRentalDate() + " Return Date: " + transactionArray[z].GetReturnDate()); //writing it out to the console
            }

            Console.WriteLine("Would you like to save this report to a file? Yes or No.");
            string userInput = Console.ReadLine();


            if (userInput.Equals("yes", StringComparison.InvariantCultureIgnoreCase)) //when user says yes
            Console.WriteLine("What would you like to name the file?");
            string userChoice = Console.ReadLine();

            StreamWriter report = new StreamWriter(userChoice, true);

                for (int z = 0; z < count; z++) // z is counting the whole transcation array
                {
                    String example = transactionArray[z].GetCustomerEmail();
                    report.WriteLine(transactionArray[z].GetCustomerEmail() + " #" + transactionArray[z].GetCustomerName() + transactionArray[z].GetRentalDate() 
                        + transactionArray[z].GetRentalDate()); //writing it out to the file they want to save
                }
            
            report.Close(); //close the file
                
            
        }
         //method to popuate Transcation Array
        public static int populateTransaction(Transaction[] transactionArray)
        {
            StreamReader Transaction = new StreamReader("transactions.txt"); //opens the file named listings.txt

            //delimiter
            int x = 0;

            while (Transaction.Peek() != -1) //the method will return -1 when it reaches end of file
            {
                string fileInput = Transaction.ReadLine(); //read the file
                char delimiter = '#';
                string[] rentArray = fileInput.Split(delimiter); //split by delimiter
                Transaction newTransaction = new Transaction(int.Parse(rentArray[0]), int.Parse(rentArray[1]), rentArray[2], (rentArray[3]), int.Parse(rentArray[4]), int.Parse(rentArray[5])); //save into a new object
                transactionArray[x] = newTransaction; //save into the array
                x++; //increase count
            }
            return x;
        }
         //selection sort
        public static void sortArray(Transaction[] myTransaction, int count)
        {
            int minIndex;

            for (int x = 0; x < count - 1; x++)
            {
                minIndex = x;
                for (int i = x + 1; i < count; i++)
                {
                    if (myTransaction[i].GetCustomerName().CompareTo(myTransaction[minIndex].GetCustomerName()) < 0) //if customer is less than other customer
                    {
                        minIndex = i;
                    }
                    else if (myTransaction[i].GetCustomerName().Equals(myTransaction[minIndex])) //if customer is the same 
                    {
                        if (myTransaction[i].GetRentalDate().CompareTo(myTransaction[minIndex].GetRentalDate()) < 0) //sort by date because the customer was the same
                        {
                            minIndex = i;
                        }
                    }
                }
                if (minIndex != x)
                {
                    swapArray(myTransaction, x, minIndex);
                }
            }
        }

        //holds a temporay varibale until swaped
        public static void swapArray(Transaction[] myTranscation, int x, int y)
        {
            Transaction temp;
            temp = myTranscation[x];
            myTranscation[x] = myTranscation[y];
            myTranscation[y] = temp;
        }

        //selection sort by date
         public static void sortByDate(Transaction[] myTransaction, int count)
        {
            int minIndex;

            for (int x = 0; x < count - 1; x++)
            {
                minIndex = x;
                for (int i = x + 1; i < count; i++)
                {
                    if (myTransaction[i].GetRentalDate().CompareTo(myTransaction[minIndex].GetRentalDate()) < 0) //if date is less than other date
                    {
                        minIndex = i;
                    }
                }
                if (minIndex != x)
                {
                    swapArray(myTransaction, x, minIndex);
                }
            }
        }
    }
}