using System;
using System.Collections.Generic;

namespace task3;

class Program
{
    static void Main()
    {
        Dictionary<int, decimal> accountsDictionary = new Dictionary<int, decimal>();
        /// add some accounts first argument is account number second is balance
        accountsDictionary.Add(1001, 5000.00m);
        accountsDictionary.Add(1002, 3000.00m);
        foreach (var account in accountsDictionary)
        {
            Console.WriteLine($"Account Number: {account.Key}, Balance: {account.Value}");
        }

        List<(int, decimal)> accountsList = new List<(int, decimal)>();
        accountsList.Add((1001, 5000.00m));
        accountsList.Add((1002, 3000.00m));
        foreach (var account in accountsList)
        {
            Console.WriteLine($"Account Number: {account.Item1}, Balance: {account.Item2}");
        }

        SortedList<int, decimal> accountsSortedList = new SortedList<int, decimal>();
        accountsSortedList.Add(1001, 5000.00m);
        accountsSortedList.Add(1002, 3000.00m);
        foreach (var account in accountsSortedList)
        {
            Console.WriteLine($"Account Number: {account.Key}, Balance: {account.Value}");
        }

        SortedDictionary<int, decimal> accountsSortedDictionary = new SortedDictionary<int, decimal>();
        accountsSortedDictionary.Add(1001, 5000.00m);
        accountsSortedDictionary.Add(1002, 3000.00m);
        foreach (var account in accountsSortedDictionary)
        {
            Console.WriteLine($"Account Number: {account.Key}, Balance: {account.Value}");
        }
    }
}