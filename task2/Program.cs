using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ShowHistory showHistory = new ShowHistory();
            showHistory.AddCategory("Alice", "Sports");
            showHistory.AddCategory("Alice", "Music");
            showHistory.AddCategory("Bob", "Movies");
            
            Console.WriteLine("Alice's History:");
            foreach (var category in showHistory.GetUserHistory("Alice"))
            {
                Console.WriteLine(category);
            }
            Console.WriteLine("Users interested in Movies:");
            foreach (var user in showHistory.GetUserHistoryByCategory("Movies"))
            {
                Console.WriteLine(user);
            }
        }
    }
}