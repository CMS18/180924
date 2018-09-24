using System;

namespace Queries
{
    public class Movie
    {
        private int _year;

        public string Title { get; set; }
        public float Rating { get; set; }
        public int Year
        {
            get
            {
                Console.WriteLine($"Reading year {_year} on {Title}");
                return _year;
            }
            set => _year = value;
        }
    }
}
