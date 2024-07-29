using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MoviesLibrary.Models
{
    public class SerialDeserial
    {
        public static void SerializeData(List<Movies> movies)
        {
            File.WriteAllText("MoviesData.json", JsonConvert.SerializeObject(movies));
        }

        public static List<Movies> DeserializeData()
        {
            List<Movies> movies = new List<Movies>();
            string filename = "MoviesData.json";
            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);
                movies = JsonConvert.DeserializeObject<List<Movies>>(json);
            }
            return movies;
        }
    }
}

