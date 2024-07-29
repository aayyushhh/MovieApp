using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLibrary
{
    public class Movies
    {
        public static int count = 0;
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Year { get; set; }

        public string ID { get; set; }

        public Movies()
        {

        }
        public Movies(string name, string genre, string year)
        {
            Name = name;
            Genre = genre;
            Year = year;
            count++;
        }

        public static int TotalCount()
        {
            return count;
        }
    }



}
