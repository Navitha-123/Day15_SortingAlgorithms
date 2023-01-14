using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_SortingAlgorithms
{
    public class UC3_InsertionSort
    {
        public static void DisplayInsertion()
        {
            int[] array = new int[5] { 23, 9, 85, 12, 99 };
            int n = 5, i, j, val, flag;
            Console.WriteLine("insertion array");
            Console.WriteLine("Intial array");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
            for (i = 1; i < n; i++)
            {
                val = array[1];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = val;
                    }
                    else
                        flag = 1;
                }

                Console.WriteLine("sorrted array:");
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
