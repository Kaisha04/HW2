using System;

namespace task6
{
 
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> sortedList = new SortedList<string, string>();
            //full collection of names and surnames for show how sorted list works in alphabetical order
            sortedList.Add("Alice", "Smith");
            sortedList.Add("Bob", "Johnson");
            sortedList.Add("Charlie", "Williams");
            //print comment how looks like sorted list in alphabetical order

            Console.WriteLine("Sorted List:");
            foreach (var item in sortedList)
            {
                Console.WriteLine($"Name: {item.Key}, Surname: {item.Value}");
            }

            //Reverse the order of the sorted list and print it in reverse order
            
            for (int i = sortedList.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($"Index: {i}, Name: {sortedList.Keys[i]}, Surname: {sortedList.Values[i]}");
            }

        }
    }
}