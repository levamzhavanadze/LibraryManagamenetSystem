using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LibraryManagamenetSystem
{
    internal class UserInterface
    {
        BookManager consoleManagedBooks = new BookManager();

        public void Menu()
        {
            Console.WriteLine("\n 1 - add new book \n 2 - see all available books \n 3 - search book by title");

            // UserInterface userInteractive = new UserInterface();
            int userInput = ParseUserInputToInt();

            if (userInput == 1)
            {
                AskUserToCreateBooks();

            }
            else if (userInput == 2)
            {
                GetLibraryBooks();
            }
            else if (userInput == 3)
            {
                SearchBooks();
            }
        }
        public int ParseUserInputToInt()
        {
            var userInput = Console.ReadLine();
            int targetInt = -99999999;

            while (int.TryParse(userInput, out targetInt) == false || targetInt == -99999999)
            {
                Console.WriteLine($"Please enter valid input, you entered: <{userInput}>");
                userInput = Console.ReadLine();
            }
            return targetInt;



        }
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
            consoleManagedBooks.CreateBook(usrBookTitle, usrBookAuthor, usrBookPublishingYear);
            Console.WriteLine("Contgratulation, you successfully added new book in library. Book you added is:");
            //print newly added book
            consoleManagedBooks.SearchBookByTitle(usrBookTitle);


            //Check if user wants to add more books
            Console.WriteLine("\nWould you like to add more? \n\t Click 1 on keyboard to continue \n\t Click any other number to return to main Menu");

            int addMore = ParseUserInputToInt();
            while (addMore == 1)
            {
                AskUserToCreateBooks();

                var userAnswer = Console.ReadLine();
                if (userAnswer.ToString().ToLower() != "y")
                {
                    addMore = 0;
                }
            }
            Console.WriteLine("Thank you, you returned to main menu.");
            Menu();

        }
        public void GetLibraryBooks()
        {
            consoleManagedBooks.GetAllBooks();
            Console.WriteLine("\nWhat is next?");
            Menu();
        }
        public void SearchBooks()
        {
            Console.WriteLine("Please enter the title of the book(s) to see it's details:");

            var usrSearchedTitle = Console.ReadLine().ToLower();
            consoleManagedBooks.SearchBookByTitle(usrSearchedTitle);

            Console.WriteLine("\nWhat is next?"); ;
            Menu();
        }
    }
}
