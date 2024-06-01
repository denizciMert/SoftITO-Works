using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftITO_Works
{
    internal class UselessAlgorithm
    {
        public static void Main()
        {
            List<int> list21 = [1, 3, 5];
            List<int> list11 = [2, 4, 6];

            //List<int> resultList = list1.ToList();
            //resultList.AddRange(list2);

            //void Sort(List<int> list)
            //{
            //    for (int i = 0; i < list.Count; i++)
            //    {
            //        for (int j = 0; j < list.Count - 1; j++)
            //        {
            //            int number1 = list[j];
            //            int number2 = list[j + 1];
            //            if (number1 > number2)
            //            {
            //                list[j] = number2;
            //                list[j + 1] = number1;
            //            }
            //            else if (number1 < number2)
            //            {
            //                list[j] = number1;
            //                list[j + 1] = number2;
            //            }
            //        }
            //    }
            //}
            //Sort(resultList);


            //foreach (var res in resultList)
            //{
            //    Console.WriteLine(res);
            //}

            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();

            int[] list1 = { 4, 5, 6 };
            int[] list2 = { 1, 2, 3 };
            int[] list3 = new int[list1.Length + list2.Length];
            int i, j, k;

            j = 0;
            k = 0;
            for (i = 0; i < list1.Length; i++)
            {
                while (j < list2.Length && list2[j] < list1[i])
                {
                    list3[k] = list2[j];
                    j++;
                    k++;
                }
                list3[k] = list1[i];
                k++;
            }
            for (i = j; i < list2.Length; i++)
            {
                list3[k] = list2[i];
                k++;
            }
            for (i = 0; i < list3.Length; i++)
            {
                Console.WriteLine(list3[i]);
            }

            stopwatch1.Stop();
            Console.WriteLine("rafet timer: " + stopwatch1);

            stopwatch1.Reset();
            stopwatch1.Start();

            List<int> bigList;
            List<int> litList;
            if (list11.Count >= list21.Count)
            {
                bigList = list11;
                litList = list21;
            }
            else
            {
                bigList = list21;
                litList = list11;
            }
            List<int> results = new List<int>();
            int ji = 0;
            for (int ii = 0; ii < litList.Count;)
            {
                if (bigList[ji] > litList[ii])
                {
                    results.Add(litList[ii]);
                    ii++;
                }
                else
                {
                    results.Add(bigList[ji]);
                    ji++;
                }

            }
            if (ji != bigList.Count)
            {
                for (int ki = ji; ki < bigList.Count; ki++)
                {
                    results.Add(bigList[ki]);
                }
            }

            foreach (var num in results)
            {
                Console.WriteLine(num);
            }

            stopwatch1.Stop();
            Console.WriteLine("mert timer: " + stopwatch1);
        }
    }
}
