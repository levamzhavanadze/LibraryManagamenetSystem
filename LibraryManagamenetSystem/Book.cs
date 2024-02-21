namespace LibraryManagamenetSystem
{
    internal class Book
    {
        public int Id { get; set; }
        //helper Id to generate incrimental ID
        static int tempId;
        public string Title { get; set; }

        public string Author { get; set; }

        public DateTime PublishingYear { get; set; }


        public Book(string title, string author, int publishingYear)
        {

            Id = GenerateId();
            Title = title;
            Author = author;
            PublishingYear = new DateTime(publishingYear, 1, 1);

        }

        /// <summary>
        /// Generates incremental Id for each instance of the book
        /// </summary>
        /// <returns>tempId</returns>
        internal int GenerateId()
        {
            tempId++;
            return tempId;
        }

        /// <summary>
        /// Prints the details of the book
        /// </summary>
        public void BookDetails()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"BookId = {Id}; Title =  {Title}; Author = {Author}; Year of Publishing = {PublishingYear.Year} ";
        }
    }
}
