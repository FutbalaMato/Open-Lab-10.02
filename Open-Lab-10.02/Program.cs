using System;

namespace Open_Lab_10._01
{
    class Program
    {
        class Book
        {
            private string title;
            private int pages;
            private string category;
            private string author;
            private int releaseDate;

            public void SetTitle(string newTitle)
            {
                title = newTitle;
            }
            public void SetPages(int newPages)
            {
                pages = newPages;

            }
            public void SetCategory(string newCategory)
            {
                category = newCategory;
            }
            public void SetAuthor(string newString)
            {
                author = newString;
            }
            public void SetReleaseDate(int newReleaseDate)
            {
                releaseDate = newReleaseDate;
            }
            public string ReturnParameters()
            {
                string s = "Title: " + title;
                s += "\nPages: " + pages;
                s += "\nCategory: " + category;
                s += "\nAuthor: " + author;
                s += "\nReleaseDate: " + releaseDate;
                return s; 
            }
        }
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.SetTitle("Samova cesta");
            LOTR.SetPages(420);
            LOTR.SetCategory("Thriller");
            LOTR.SetAuthor("Mato");
            LOTR.SetReleaseDate(2069);

            Console.WriteLine(LOTR.ReturnParameters());

            




            





        }
    }

}
