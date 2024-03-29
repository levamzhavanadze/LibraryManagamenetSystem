﻿using LibraryManagementSystem;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class UserConsoleUI : Validators
    {
        readonly BookManager consoleManagedBooks = new();

        /// <summary>
        /// Method responsible to show possible options to user for navigation
        /// </summary>
        public void Menu()
        {
            Console.WriteLine("\n 1 - add new book \n 2 - see all available books \n 3 - search book by title \n 4 - Exit");

            //Catching user input and validating it if entered value is int or not
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
            else if (userInput == 4)
            {
                Console.WriteLine("Thank you for using our Console App.");


                // Pause the program for 4 seconds
                Thread.Sleep(2000);

                // Close the console window
                Environment.Exit(0);
            }

        }

        /// <summary>
        /// Method is responsible to ask user to add new book, confirm successful transaction and ask about next step.
        /// </summary>
        public void AskUserToCreateBooks()
        {
            //providing information what data is required to add new book.
            Console.WriteLine("Pease add new book by entering Title, Author and Publishing Year");
            string usrBookTitle = null;
            string usrBookAuthor = null;
            int usrBookPublishingYear;

            //Capturing Title
            Console.Write("Title:\t");
            usrBookTitle = ValidateUserInputOnEmptyString();

            //Capturing Author
            Console.Write("Author:\t");
            usrBookAuthor = ValidateUserInputOnEmptyString();

            //Capturing Year
            Console.Write("Year:\t");
            usrBookPublishingYear = ParseUserInputToInt();

            //create book based on user inputs
            consoleManagedBooks.CreateBook(usrBookTitle, usrBookAuthor, usrBookPublishingYear);
            Console.WriteLine("Contgratulation, you successfully added new book in library. Book you added is:");
            //print newly added book to confirm successfull transaction
            consoleManagedBooks.SearchBookByTitle(usrBookTitle);


            Console.WriteLine("\nWould you like to add more? \n\t Click 1 on keyboard to continue \n\t Click any other number to return to main Menu");
            //Check if user wants to add more books
            int addMore = ParseUserInputToInt();
            while (addMore == 1)
            {
                //if user input is 1, then method is invoked from beginning
                AskUserToCreateBooks();
            }
            Console.WriteLine("Thank you, you returned to main menu.");
            //if user doesn't want to add additional book, displaying initial menu.
            Menu();
        }
        /// <summary>
        /// Meethod is responsible to initiate BookManager getAllBooks method.
        /// </summary>
        public void GetLibraryBooks()
        {
            //get all books details 
            consoleManagedBooks.GetAllBooks();

            //asking user about next step by invoking initial menu
            Console.WriteLine("\nWhat is next?");
            Menu();
        }
        /// <summary>
        /// Method is responsible to capture user entered book title and pass it to BookManager method for searching this book.
        /// </summary>
        public void SearchBooks()
        {
            Console.WriteLine("Please enter the title of the book(s) to see it's details:");
            //convert user inputted info to lower
            var usrSearchedTitle = Console.ReadLine().ToLower();

            //invoking and passing user inputted title value to BookManager
            consoleManagedBooks.SearchBookByTitle(usrSearchedTitle);

            //asking user about next step by invoking initial menu
            Console.WriteLine("\nWhat is next?"); ;
            Menu();
        }
    }
}
