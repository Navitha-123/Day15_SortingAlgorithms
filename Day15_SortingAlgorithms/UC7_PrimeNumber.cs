using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_SortingAlgorithms
{
    public class UC7_PrimeNumber
    {
        public static void PrintPrimeNumber()
        {
            int flag, i, j;
            Console.WriteLine("Print Prime number between 0 to 1000");
            for (i = 0; i <= 1000; i++)
            {
                if (i == 0 || i == 1)
                    continue;

                flag = 1;

                for (j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}

