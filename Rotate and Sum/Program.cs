using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lineOfDigits = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int countRotation = int.Parse(Console.ReadLine());//дотук сме прочели входните данни: маива от 1ред числа и бр.завъртания

            int[] sumArray = new int[lineOfDigits.Length];//инициализираме масива за сумиране

            for (int i = 0; i < countRotation; i++) //пускаме фор-цикъл от 0 до бр.въртения countRotation,зададени от конзолата
            {
                int lastValue = lineOfDigits[lineOfDigits.Length - 1];//за първото завъртане хващаме последната стойност lastValue, която ще подлежи на местене най-отпред
                //тя е равна на дължината на масива, състоящ се от индексите на зададения ред от числа
                for (int j = lineOfDigits.Length - 1; j > 0; j--) // за второто завъртане влагаме обратен фор-цикъл
                {
                    lineOfDigits[j] = lineOfDigits[j - 1];
                }
                lineOfDigits[0] = lastValue;

                for (int g = 0; g < lineOfDigits.Length; g++) //трети фор-цикъл за сумирането на двете линии от числа
                {
                    sumArray[g] = sumArray[g] + lineOfDigits[g];
                }
            }
            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
