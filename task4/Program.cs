using System;
using System.Collections;
using System.Collections.Specialized;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            NewOrderedDictionary orderedDictionary = new NewOrderedDictionary();
            orderedDictionary.Add("Alice", 25);
            orderedDictionary.Add("Bob", 30);
            orderedDictionary.Add("Charlie", 20);

            Console.WriteLine("Ordered Dictionary:");
            foreach (DictionaryEntry entry in orderedDictionary)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
           
            int comparisonResult = orderedDictionary.Compare("Alice", "Bob");
            if (comparisonResult < 0)
            {
                Console.WriteLine("Alice's value is less than Bob's value.");
            }
            else if (comparisonResult > 0)
            {
                Console.WriteLine("Alice's value is greater than Bob's value.");
            }
            else
            {
                Console.WriteLine("Alice's value is equal to Bob's value.");
            }
        }
    }

    class NewOrderedDictionary : OrderedDictionary, IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentNullException("Keys cannot be null.");
            }
            if (!this.Contains(x) || !this.Contains(y))
            {
                throw new ArgumentException("Both keys does not exist in the dictionary.");
            }

            object? valueX = this[x];
            object? valueY = this[y];
            if (valueX?.GetType() != valueY?.GetType())
            {
                throw new ArgumentException("Values are not of the same type.");
            }

            if (valueX is IComparable comparableX && valueY is IComparable comparableY)
            {
                return comparableX.CompareTo(comparableY);
            }
            else
            {
                throw new ArgumentException("Values are not comparable.");
            }
        }
    }
}

