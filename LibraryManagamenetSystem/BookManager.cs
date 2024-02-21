using System.Collections;

namespace LibraryManagementSystem
{
    /// <summary>
    /// This class is responsible to manage books 
    /// </summary>
    internal class BookManager : IEnumerable
    {
        readonly List<Book> books = [];

        //ახალი წიგნის დამატება სიაში
        public void CreateBook(string bookTitle, string bookAuthor, int publishingYear)
        {
            //adding books in the list
            books.Add(new Book(bookTitle, bookAuthor, publishingYear));
        }

        //ყველა წიგნის სიის ჩვენება.
        public void GetAllBooks()
        {
            //checks if there is no books in the list prints corresponding message
            if (books.Count() != 0)
            {
                //Print all book details
                foreach (var book in books)
                {
                    book.BookDetails();
                }
            }
            else
            {
                Console.WriteLine("There are no books in library yet, please add new one from main menu");
            }
        }

        //წიგნის ძებნა მისი სათაურის მიხედვით.
        public void SearchBookByTitle(string title)
        {
            //checks if there is no books in the list prints corresponding message
            if (books.Count != 0)
            {
                //generate temp list matched with passed title
                var booksFilteredByTitle = from b in books
                                               //where b.Title.ToLower() == title
                                           where b.BookTitle().Equals(title, StringComparison.CurrentCultureIgnoreCase)
                                           select b;
                //check if there is no book in the list with this title return appropriate message
                if (booksFilteredByTitle.Count() != 0)
                {
                    foreach (var i in booksFilteredByTitle)
                    {
                        Console.WriteLine(i);
                    }
                }

                else
                {
                    Console.WriteLine($"There is no book(s) in library with this title: {title}");
                }
            }
            else
            {
                Console.WriteLine("There are no books in library yet, please add new one from main menu");
            }



        }

        public IEnumerator GetEnumerator()
        {
            return books.GetEnumerator();
        }

    }
}
