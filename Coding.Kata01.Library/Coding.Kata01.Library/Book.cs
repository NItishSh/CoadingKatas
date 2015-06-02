using System.Collections.Generic;

namespace Coding.Kata01.Library
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public List<string> Categories { get; set; }

        public Book()
        {
            Categories = new List<string>();
        }
    }
}
