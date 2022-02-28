using System;
using System.Collections.Generic;
using System.Linq;


namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<string,int> dictionary = new Dictionary<string, int>();
            foreach (string key in input)
            {
                string lowerKey = key.ToLower();
                if (dictionary.ContainsKey(lowerKey))
                {
                    dictionary[lowerKey]++;
                }
                else
                {
                    dictionary.Add(lowerKey, 1);
                }
            }
            foreach (var value in dictionary)
            {
                if (value.Value % 2 !=0)
                {
                    Console.Write($"{value.Key} ");
                }
                
            }
        }
    }
}
