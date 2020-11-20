using System;
using System.IO;

namespace pa5_kdtaylor3
{
    public class Book
    {
         private string ISBN;
        private string title;
        private string author;
        private string genre;
        private int totalListeningTime;
        private int copies;
        static private int count;

        public Book()
        {
            ISBN = " ";
            title = " ";
            author = " ";
            genre = " ";
            totalListeningTime = 0;
            copies = 0;
        }
        public Book(string tempISBN, string tempTitle, string tempAuthor, string tempGenre, int tempTotalListeningTime, int tempCopies)
        {
            ISBN = tempISBN;
            title = tempTitle;
            author = tempAuthor;
            genre = tempGenre;
            totalListeningTime = tempTotalListeningTime;
            copies = tempCopies;
        }

        public string GetISBN()
        {
            return ISBN;
        }
        public void SetISBN(string tempISBN)
        {
            ISBN = tempISBN;
        }

        public string GetTitle()
        {
            return title;
        }
        public void SetTitle(string tempTitle)
        {
            title = tempTitle;
        }

        public string GetAuthor()
        {
            return author;
        }
        public void SetAuthor(string tempAuthor)
        {
            author = tempAuthor;
        }

        public string GetGenre()
        {
            return genre;
        }
        public void SetGenre(string tempGenre)
        {
            genre = tempGenre;
        }

        public int GetTotalListeningTime()
        {
            return totalListeningTime;
        }
        public void SetTotalListeningTime(int tempTotalListeningTime)
        {
            totalListeningTime = tempTotalListeningTime;
        }

        public int GetCopies()
        {
            return copies;
        }
        public void SetCopies(int tempCopies)
        {
            copies = tempCopies;
        }

        public void SetValues(string tempISBN, string tempTitle, string tempAuthor, string tempGenre, int tempTotalListeningTime, int tempCopies)
        {
            ISBN = tempISBN;
            title = tempTitle;
            author = tempAuthor;
            genre = tempGenre;
            totalListeningTime = tempTotalListeningTime;
            copies = tempCopies;
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

        public void IncCopies()
        {
            copies++;
        }

        public new string ToString()
        {
            return title + " " + author + " " + genre + " " + totalListeningTime + " " + copies;
        }

        static public void PrintAllBooks(Book[] myArray)
        {
            Console.WriteLine("\nName ID Gender Birthday Rank GPA GraduationYear");

            for (int i = 0; i < Book.GetCount(); i++)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}",
                    myArray[i].GetISBN(), myArray[i].GetTitle(), myArray[i].GetAuthor(),
                    myArray[i].GetGenre(), myArray[i].GetTotalListeningTime(), myArray[i].GetCopies());
            }
        }

        static public void WriteAllBooks(Book[] myArray)
        {
            StreamWriter outFile = new StreamWriter("books.txt", true);

            for (int i = 0; i < Book.GetCount(); i++)
            {
                outFile.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}",
                    myArray[i].GetISBN(),
                    myArray[i].GetTitle(),
                    myArray[i].GetAuthor(),
                    myArray[i].GetGenre(),
                    myArray[i].GetTotalListeningTime(),
                    myArray[i].GetCopies());
            }

            outFile.Close();

        }


        static public void SortAllBook(Book[] myArray)
        {
            int minIndex;

            for (int i = 0; i < count - 1; i++)
            {
                minIndex = i;

                for (int j = i + 1; j < count; j++)
                {
                    if (myArray[j].GetTitle().CompareTo(myArray[minIndex].GetTitle()) < 0 ||
                        (myArray[j].GetTitle().CompareTo(myArray[minIndex].GetTitle()) == 0 && myArray[j].GetCopies() < myArray[minIndex].GetCopies()))
                        minIndex = j;
                }

                if (minIndex != i)
                    Book.SwapArray(myArray, i, minIndex);

            }
        }

        static public void SwapArray(Book[] myArray, int i1, int i2)
        {
            Book tempBook = new Book(myArray[i1].GetISBN(), myArray[i1].GetTitle(), myArray[i1].GetAuthor(), myArray[i1].GetGenre(), myArray[i1].GetTotalListeningTime(), myArray[i1].GetCopies());

            myArray[i1].SetISBN(myArray[i2].GetISBN());
            myArray[i1].SetTitle(myArray[i2].GetTitle());
            myArray[i1].SetAuthor(myArray[i2].GetAuthor());
            myArray[i1].SetGenre(myArray[i2].GetGenre());
            myArray[i1].SetTotalListeningTime(myArray[i2].GetTotalListeningTime());
            myArray[i1].SetCopies(myArray[i2].GetCopies());


            myArray[i2].SetISBN(tempBook.GetISBN());
            myArray[i2].SetTitle(tempBook.GetTitle());
            myArray[i2].SetAuthor(tempBook.GetAuthor());
            myArray[i2].SetGenre(tempBook.GetGenre());
            myArray[i2].SetTotalListeningTime(tempBook.GetTotalListeningTime());
            myArray[i2].SetCopies(tempBook.GetCopies());
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
        
      
    }
}