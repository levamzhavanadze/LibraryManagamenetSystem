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
            foreach (var book in books)
            {
                book.BookDetails();
            }
        }

        //წიგნის ძებნა მისი სათაურის მიხედვით.
        public void SearchBookByTitle(string title)
        {
            var bookByTitle = from b in books
                              where b.Title == title
                              select b;

            foreach (var i in bookByTitle)
            {
                Console.WriteLine(i);
            }
        }

    }
}
