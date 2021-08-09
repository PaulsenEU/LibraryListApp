using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAppLibrary
{
    public class Book
    {

        public List<Book> listOfBooks { get; set; } = new List<Book>();
        private string author;
        private string title;
        private string genre;


        public string addAuthor { get; set; }

        public string addTitle { get; set; }

        public string addGenre
        {
            get; set;
        }
    }
}
