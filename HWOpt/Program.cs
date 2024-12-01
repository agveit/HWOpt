using System;
using System.Collections.Generic;
using System.Linq;

namespace HWOpt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Это пример текста. Текст должен быть проанализирован. Это важно.";
            Dictionary<string, int> wordCounts = WordFrequency(text);

            foreach (var item in wordCounts)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        static Dictionary<string, int> WordFrequency(string text)
        {
            string[] words = text.ToLower().Split(new[] { ' ', '.'}, StringSplitOptions.RemoveEmptyEntries);

            return words.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
        }
    }
}
