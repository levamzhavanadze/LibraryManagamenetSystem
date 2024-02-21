using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamenetSystem
{
    internal class UserInterface
    {
        BookManager userAddedBook = new BookManager();
        public void AskUserToCreateBooks()
        {

            Console.WriteLine("Pease add new book by entering Title, Author and Publishing Year");
            string usrBookTitle = null;
            string usrBookAuthor = null;
            int usrBookPublishingYear = -1;


            Console.Write("Title:\t");
            usrBookTitle = Console.ReadLine();

            Console.Write("Author:\t");
            usrBookAuthor = Console.ReadLine();

            Console.Write("Year:\t");
            //Coud use the method ParseUserinput, but wanted to have specific message in while loop.
            var userInput = Console.ReadLine();

            while (int.TryParse(userInput, out usrBookPublishingYear) == false || usrBookPublishingYear == -1)
            {
                Console.WriteLine($"Please enter valid year for book <{usrBookTitle}> written by <{usrBookAuthor}>, you entered: <{userInput}>");
                userInput = Console.ReadLine();
            }

            //create book based on iputs
            userAddedBook.CreateBook(usrBookTitle, usrBookAuthor, usrBookPublishingYear);
            Console.WriteLine("Contgratulation, you successfully added new book in library. Book you added is:");
            //print newly added book
            userAddedBook.SearchBookByTitle(usrBookTitle);


            //Check if user wants to add more books
            Console.WriteLine("\nWould you like to add more? \n\tPress <Y> to continue");

            int addMore = ParseUserInput();
            while (addMore == 1)
            {
                AskUserToCreateBooks();
               
                var userAnswer = Console.ReadLine();
                if (userAnswer.ToString().ToLower() != "y")
                {
                    addMore = 0;
                }
            }

        }

        public int ParseUserInput()
        {
            var userInput = Console.ReadLine();
            int targetInt= -99999999;

            while (int.TryParse(userInput, out targetInt) == false || targetInt == -99999999)
            {
                Console.WriteLine($"Please enter valid number, you entered: <{userInput}>");
                userInput = Console.ReadLine();
            }
            return targetInt;
        }
        public void GetLibraryBooks()
        {
            userAddedBook.GetAllBooks();
        }
    }
}
