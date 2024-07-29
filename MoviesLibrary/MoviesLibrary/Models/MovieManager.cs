namespace MoviesLibrary.Models
{
    public class MovieManager
    {
        public static List<Movies> movieslist = new List<Movies>();



        public static void CallMainMenu()
        {

            while (true)
            {
                Console.WriteLine("Welcome to Movie Store");
                Console.WriteLine("----------------------------");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Total Movie Available :" + Movies.TotalCount());
                Console.WriteLine("1.Add Movie");
                Console.WriteLine("2.Display Movie");
                Console.WriteLine("3.Delete Movie");
                Console.WriteLine("4. Clear All movies");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter your choice");
                int userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        AddMovie();
                        break;
                    case 2:
                        DisplayAll();
                        break;
                    case 3:
                        DeleteMovie();
                        break;
                    case 4:
                        ClearAll();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
                SerialDeserial.SerializeData(movieslist);
            }

        }

        public static void ClearAll()
        {
            Console.WriteLine("Do you really want to clear all movies ?(Y/N)");
            string input = Console.ReadLine();
            switch (input)
            {
                case "Y":
                    movieslist.Clear();
                    Movies.count = 0;
                    Console.WriteLine("Movies List cleared!");
                    break;
                case "N":
                    Environment.Exit(0);
                    break;
            }
        }

            public static void AddMovie()
        {
            Movies newmovie = new Movies();
            try
            {
                if (movieslist.Count == 5)
                {
                    throw new CapacityFullException("Movie Capacity is Full");
                }

                Console.WriteLine("Movie Name :");
                newmovie.Name = Console.ReadLine();

                Console.WriteLine("Movie Genre:");
                newmovie.Genre = Console.ReadLine();

                Console.WriteLine("Movie Year of Release:(yyyy)");
                newmovie.Year = Console.ReadLine();

                newmovie.ID = newmovie.Name.Substring(0, 2) + "" + newmovie.Genre.Substring(0, 2) + "" + newmovie.Year.Substring(0, 2);

                Movies.count++;
                movieslist.Add(newmovie);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }


        }

        public static void DeleteMovie()
        {
            try
            {
                if (movieslist.Count == 0)
                {
                    throw new MovieStoreEmptyException("Movie Store Empty");
                }

                Console.WriteLine("Enter the Id to delete");
                string movieId = Console.ReadLine();
                foreach (var movie in movieslist)
                {
                    if (string.Equals(movie.ID, movieId))
                    {
                        movieslist.Remove(movie);
                        Console.WriteLine("Movie Deleted");
                        Movies.count--;
                        break;
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void DisplayAll()
        {
            Movies moviesall = null;

            foreach (var movie in movieslist)
            {
                PrintDetails(movie);
            }


        }
        public static void PrintDetails(Movies movie)
        {
            Console.WriteLine("Id is " + movie.ID);
            Console.WriteLine("Name is " + movie.Name);
            Console.WriteLine("Genre is " + movie.Genre);
            Console.WriteLine("Balance is " + movie.Year);


        }

    }
}
