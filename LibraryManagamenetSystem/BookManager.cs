namespace LibraryManagamenetSystem
{
    /// <summary>
    /// This lass is responsible to manage books 
    /// </summary>
    internal class BookManager
    {
        readonly List<Book> books = [];

        //ახალი წიგნის დამატება სიაში
        public void CreateBook(string bookTitle, string bookAuthor, int publishingYear)
        {
            books.Add(new Book(bookTitle, bookAuthor, publishingYear));
        }

        //ყველა წიგნის სიის ჩვენება.
        public void GetAllBooks()
        {
            if (books.Count() != 0)
            {
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
            if (books.Count() != 0)
            {
                var booksFilteredByTitle = from b in books
                                           where b.Title.ToLower() == title
                                           select b;
                if (booksFilteredByTitle.Count() != 0)
                {
                    foreach (var i in booksFilteredByTitle)
                    {
                        Console.WriteLine(i);
                    }
                }

                else
                {
                    Console.WriteLine("There is no book(s) in library with this title");
                }
            }
            else
            {
                Console.WriteLine("There are no books in library yet, please add new one from main menu");
            }



        }

    }
}
