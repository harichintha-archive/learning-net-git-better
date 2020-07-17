using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForBest
{
    class AxxessPractice
    {
        public static bool CheckPrimeOrNot(int N)
        {
            for (int i = 2; i <= N / 2; i++)
            {
                if (N % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static void PrintPrimes(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }
                }

            }
        }
        public static void StringConvertion()
        {

        }
        public static void PrintSequence(int N, int SN)
        {
            int q = N / 10;
            int r = N % 10;
            if (N >= 6 && N <= 9)
            {
                Console.WriteLine(SN);
            }
            else
            {
                if (N > 5)
                {
                    if (r != 0 && r < SN)
                    {
                        for (int i = 0; i <= q - 2; i++)
                        {
                            Console.WriteLine(SN + i * 10);
                        }

                    }
                    else if (r == 0 || r >= SN)
                    {
                        for (int i = 0; i <= q - 1; i++)
                        {
                            Console.WriteLine(SN + i * 10);
                        }
                    }
                }
            }
        }

        public static void DoorStatus(int Doors)
        {
            int openDoorsCount = 0;

            for (int i = 1; i <= Doors; i++)
            {
                int factorsCount = 0;
                for (int j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        factorsCount++;
                    }
                }
                factorsCount++;
                if (!(factorsCount % 2 == 0))
                {
                    openDoorsCount++;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Total doors open: {0}", openDoorsCount);
        }


        static void Main()
        {
            Stopwatch s1 = new Stopwatch();
            s1.Start();
            //PrintSequence(-124,6);
            // DoorStatus(90000);
            Console.WriteLine(CheckPrimeOrNot(4));
            s1.Stop();
            Console.WriteLine("Time taken: {0} ", s1.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
    public class SingletonDemoClass
    {

    }
}
