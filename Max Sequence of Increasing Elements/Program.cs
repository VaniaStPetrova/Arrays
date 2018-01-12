using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int startPos = 0;
            int lenOfIncreasing = 1;
            int bestStartPos = 0;
            int bestLen = 1;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] >= input[i - 1] + 1)
                {
                    lenOfIncreasing++;
                    if (lenOfIncreasing > bestLen)
                    {
                        bestStartPos = startPos;
                        bestLen = lenOfIncreasing;
                    }
                }
                else
                {
                    startPos = i;
                    lenOfIncreasing = 1;
                }
            }
            for (int i = bestStartPos; i < bestStartPos + bestLen; i++)
            {
                Console.Write(input[i] + " ");
            }
        }
    }
}
