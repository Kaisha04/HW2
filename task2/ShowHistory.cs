using System;
using System.Collections.Generic;

namespace task2
{
    class ShowHistory
    {
        private Dictionary<string, List<string>> history = new Dictionary<string, List<string>>();

        public void AddCategory(string user, string category)
        {
            if (!history.ContainsKey(user))
            {
                history[user] = new List<string>();
            }
            history[user].Add(category);
        }

        public void DeleteCategory(string user, string category)
        {
            if (history.ContainsKey(user))
            {
                history[user].Remove(category);
            }
        }
        
        public IEnumerable<string> GetUserHistory(string user)
        {
            if (history.ContainsKey(user))
            {
                return history[user];
            }
            else
            {
                Console.WriteLine($"No history found for {user}.");
                return new List<string>();
            }
        }
        public IEnumerable<string> GetUserHistoryByCategory(string category)
        {
            List<string> usersWithCategory = new List<string>();
            foreach (var entry in history)
            {
                if (entry.Value.Contains(category))
                {
                    usersWithCategory.Add(entry.Key);
                }
            }
            return usersWithCategory;
        }

        
    }
}