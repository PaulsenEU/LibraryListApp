using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUI
{
    public class Book
    {

        public List<Book> listOfBooks = new List<Book>();
        private string author;
        private string title;
        private string genre;


        public void addAuthor(string author) {
            this.author = author;
        }

        public void addTitle(string title)
        {
            this.title = title;
        }
      
        public void addGenre(string genre)
        {
            this.genre = genre;
        }

        public string getAuthor()
        {
            return this.author;
        }

        public string getTitle()
        {
            return this.title;
        }

        public string getGenre()
        {
            return this.genre;
        }

    }
}
