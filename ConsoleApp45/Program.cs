using ClassLibrary1.Domain.Models;

namespace ConsoleApp45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new("Dilenci qadinin sirri",20,2,"Elxan Elatli",200);
            Console.WriteLine(book.ShowInfo());
            book.Sell();
            Console.WriteLine(book.ShowInfo());
            book.Sell();
            Console.WriteLine(book.ShowInfo());
            book.Sell();
            
        }
    }
}