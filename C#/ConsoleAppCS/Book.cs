using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCS
{
    class Book
    {
        public string title;
        public string author;
        private int page;
        string name = "hassan";
        public Book(string aTitle,string aAuthor, int aPage)
        {
            title = aTitle;
            author = aAuthor;
            page = aPage;
        }
       /* public string muthor{
            get{
                
            }
            set{
            }
        }
       */
    }
}
