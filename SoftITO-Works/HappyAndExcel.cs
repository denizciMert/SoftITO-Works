using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftITO_Works
{
    public class HappyAndExcel
    {
        static int ExcelTitles1(string str)
        {
            Stopwatch sw3 = new Stopwatch();
            sw3.Start();
            int result = str.Aggregate(0, (n, c) => n * 26 + c - 0x40);
            sw3.Stop();
            Console.WriteLine("Title to Number (OLC)" + sw3);
            return result;
        }

        static int ExcelTitles2(string str)
        {
            Stopwatch sw4 = new Stopwatch();
            sw4.Start();
            //alternatif:
            //char[] columnTitles =
            //[
            //    'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
            //    'V', 'W', 'X', 'Y', 'Z'
            //];

            int result = 0;
            foreach (var ch in str)
            {
                result = result * 26 + (ch - 'A' + 1);
                //alternatif:
                //int i = 0;
                //while (i<columnTitles.Length)
                //{
                //    if (columnTitles[i] == ch)
                //    {
                //        result = result * columnTitles.Length + (i + 1);
                //        break;
                //    }
                //    i++;
                //}
            }
            sw4.Stop();
            Console.WriteLine("Excel Titles (Mine)" + sw4);
            return result;
        }

        static bool IsHappy1(int n)
        {
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();

            //alternatif hashset?
            HashSet<int> oldNumbers = new HashSet<int>();

            while (n != 1 && !oldNumbers.Contains(n))
            {
                oldNumbers.Add(n);
                int sum = 0;
                while (n > 0)
                {
                    int digit = n % 10;
                    sum += digit * digit;
                    n /= 10;
                }

                n = sum;
            }
            sw1.Stop();
            Console.WriteLine("Is Happy (HashSet)" + sw1);
            return n == 1;
        }


        static bool IsHappy2(int n)
        {
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            //alternatif hashset?
            List<int> oldNumbers = new List<int>();

            while (n != 1 && !oldNumbers.Contains(n))
            {
                oldNumbers.Add(n);
                int sum = 0;
                while (n > 0)
                {
                    int digit = n % 10;
                    sum += digit * digit;
                    n /= 10;
                }

                n = sum;
            }
            sw2.Stop();
            Console.WriteLine("Is Happy (List)" + sw2);
            return n == 1;
        }
    }
}
