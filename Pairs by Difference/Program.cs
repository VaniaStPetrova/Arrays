using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i]; //inicializirame si edin teku6t

                for (int j = 0; j < numbers.Length; j++)
                {
                    int secondNum = numbers[j]; //t.e. wzeli sme nuleviq element, vzemame sledva6tiq...

                    if (currentNum - secondNum == difference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
