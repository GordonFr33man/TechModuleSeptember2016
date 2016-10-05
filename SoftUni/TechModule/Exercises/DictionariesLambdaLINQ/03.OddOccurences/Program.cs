using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(' ');
            Dictionary<string, int> counter = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (counter.ContainsKey(word))
                {
                    counter[word]++;
                }
                else
                {
                    counter[word] = 1;
                }
                
            }
            List<string> oddElements = new List<string>();
            foreach (KeyValuePair<string,int> word in counter)
            {
                if (word.Value%2!=0)
                {
                    oddElements.Add(word.Key);
                }
                

                
            }
            List<int> result = new List<int>();
            Console.WriteLine(string.Join(", ",oddElements));
        }
       
    }
}
