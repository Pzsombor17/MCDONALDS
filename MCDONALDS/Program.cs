namespace MCDONALDS;

internal class Program
{
    static void Main(string[] args)
    {
        List<burger> hamburger = FileManager.Readfile("burger.csv");
        List<falatkak> nuggets = FileManager.Readfile("falatkak.csv");

        Console.WriteLine("\nÜdvözöljük a McDonald's-ban");
        Console.WriteLine("\n-!! FŐMENÜ !!-");

        Console.WriteLine("1. Termékek listája");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                break;
            case "2":
                break;
        }


    }
    
}
   


