using MoviesLibrary;
using MoviesLibrary.Models;

public class Program
{
    public static void Main(string[] args)
    {
        MovieManager.movieslist = SerialDeserial.DeserializeData();
        MovieManager.CallMainMenu();
        
    }
}