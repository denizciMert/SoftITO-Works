using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftITO_Works
{
    public class AutoPredictGame
    {
        static void AutoPredictNumberGame(int maxNumber, int minNumber, int yourNumber)
        {
            Console.WriteLine("L - Lesser than this number.");
            Console.WriteLine("G - Greater than this number.");
            Console.WriteLine("C - This is the correct number.");

            int max = maxNumber;
            int min = minNumber;

            while (true)
            {
                int predicted = (max + min) / 2;
                string answer = String.Empty;
                if (predicted > yourNumber)
                {
                    answer = "L";
                }
                else if (predicted < yourNumber)
                {
                    answer = "G";
                }
                else if (predicted == yourNumber)
                {
                    answer = "C";
                }

                Console.WriteLine("\nIs Your Number : " + predicted + "\n");
                Console.WriteLine("Answer : " + answer);

                if (answer == "c" || answer == "C")
                {
                    if (predicted == yourNumber)
                    {
                        Console.WriteLine("\n----------------------\nYour Number Is : " + predicted + "\n----------------------\n");
                        break;
                    }
                    Console.WriteLine("\nNah, Its a LIE...\n");
                }
                else if (answer == "l" || answer == "L")
                {
                    max = predicted;
                }
                else if (answer == "g" || answer == "G")
                {
                    min = predicted;
                }
                else
                {
                    Console.WriteLine("\nInvalid Input.\n");
                    Console.WriteLine("L - Lesser than this number.");
                    Console.WriteLine("G - Greater than this number.");
                    Console.WriteLine("C - This is the correct number.\n");
                }
            }
        }
    }
}
