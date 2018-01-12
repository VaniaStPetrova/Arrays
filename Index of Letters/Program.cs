using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
                         string word = Console.ReadLine();

            foreach (char letter in word)
            {
                Console.WriteLine("{0} -> {1}", letter, letter - 'a');
            }
        }
    }
}
