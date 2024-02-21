namespace LibraryManagementSystem
{
    internal class Book
    {
        private int Id { get; set; }
        //helper Id to generate incremental ID
        private static int tempId;
        private string Title { get; set; }

        private string Author { get; set; }

        private DateTime PublishingYear { get; set; }


        public Book(string title, string author, int publishingYear)
        {

            Id = GenerateId;
            Title = title;
            Author = author;
            PublishingYear = new DateTime(publishingYear, 1, 1);
        }

        /// <summary>
        /// Generates incremental Id for each instance of the book
        /// </summary>
        /// <returns>tempId</returns>
        static int GenerateId
        {
            get
            {
                tempId++;
                return tempId;
            }
        }

        /// <summary>
        /// Prints the details of the book
        /// </summary>
        public void BookDetails()
        {
            Console.WriteLine(ToString());
        }

        /// <summary>
        /// Returns the book title
        /// </summary>
        /// <returns>Title</returns>
        public string BookTitle()
        {
            return Title;
        }

        public override string ToString()
        {
            return $"BookId = {Id}; Title =  {Title}; Author = {Author}; Year of Publishing = {PublishingYear.Year} ";
        }
    }
}
