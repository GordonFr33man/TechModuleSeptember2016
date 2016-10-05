using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            int k = sequence.Length / 4;
            int[] leftSeq = sequence.Take(k).Reverse().ToArray();
            int[] rightSeq = sequence.Reverse().Take(k).ToArray();
            int[] middleSeq = sequence.Skip(k).Take(2 * k).ToArray();
            for (int i = 0; i < leftSeq.Length; i++)
            {
                middleSeq[i] += leftSeq[i];
            }
            for (int i = 0; i < rightSeq.Length; i++)
            {
                middleSeq[i + k] += rightSeq[i];
            }
            Console.WriteLine(string.Join(" ",middleSeq));

            
        }
    }
}
