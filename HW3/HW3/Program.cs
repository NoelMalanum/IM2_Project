using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            string[] words = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, Dictionary<char, int>> wordFrequencies = new Dictionary<string, Dictionary<char, int>>();

            foreach (string word in words)
            {
                wordFrequencies[word] = GetCharFrequency(word);
            }

            foreach (var entry in wordFrequencies)
            {
                Console.Write($"{entry.Key}: ");
                List<string> charFreqs = new List<string>();

                foreach (var pair in entry.Value)
                {
                    charFreqs.Add($"{pair.Key}={pair.Value}");
                }

                Console.WriteLine(string.Join(", ", charFreqs));
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
        static Dictionary<char, int> GetCharFrequency(string word)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char c in word)
            {
                if (frequency.ContainsKey(c))
                    frequency[c]++;
                else
                    frequency[c] = 1;
            }

            return frequency;
        }
    }
}
