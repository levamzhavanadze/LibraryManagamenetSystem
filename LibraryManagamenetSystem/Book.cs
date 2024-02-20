using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagamenetSystem
{
    internal class Book
    {
        static int Id {  get; set; }

        public string Title { get; set; } 

        public string Author { get; set; }

        public DateTime PublishingYear { get; set; }


        public Book()
        {
            
            Id = GenerateId();
            
        }

        internal int GenerateId()
        {
            int tempId = Id;

            Id = tempId;
            tempId++;

            return tempId;
        }
        

        public override string ToString()
        {
            return $"BookId = {Id}; Title =  {Title}; Author = {Author}; Year of Publishing = {PublishingYear.Year} ";
        }
    }
}
