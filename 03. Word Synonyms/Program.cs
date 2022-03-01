using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfWords = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
            for (int i = 0; i < countOfWords; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words[word] = new List<string>();
                }

                    words[word].Add(synonim);
            }
                foreach (var word in words)
                {
                    Console.WriteLine($"{word.Key} - {string.Join(", ",word.Value)}");
                }
        }
    }
}
