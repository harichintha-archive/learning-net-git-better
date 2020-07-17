using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForBest
{
    class ProjectEuler
    {
        internal static void LargestPrimeFactor(long N)
        {
            long Num = N;
            long LPF = 0;
            long tempNumber = N;
            long counter = 2;
            while (counter * counter <= tempNumber)
            {
                if (tempNumber % counter == 0)
                {
                    tempNumber = tempNumber / counter;
                    LPF = counter;
                }
                else
                {
                    counter++;
                }
            }
            if (tempNumber > LPF)
            {
                LPF = tempNumber;
            }
            Console.WriteLine("Largest Prime Factor for {0} is: {1}", N, LPF);
        }
        internal static bool IsPrime(long N)
        {
            if (N == 1)
            {
                return false;
            }
            if (N == 2)
            {
                return true;
            }
            if (N % 2 == 0)
            {
                return false;
            }
            int counter = 3;
            while (counter * counter <= N)
            {
                if (N % counter == 0)
                {
                    return false;
                }
                else
                {
                    counter += 2;
                }
            }
            return true;
        }
        public static void digitFifthPowers()
        {

        }
        internal static int[] SieveOfEratosthenes(long upperLimit)
        {
            int sieveBound = (int)(upperLimit - 1) / 2;
            int upperSqrt = ((int)Math.Sqrt(upperLimit) - 1) / 2;

            BitArray PrimeBits = new BitArray(sieveBound + 1, true);

            for (int i = 1; i <= upperSqrt; i++)
            {
                if (PrimeBits.Get(i))
                {
                    for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1)
                    {
                        PrimeBits.Set(j, false);
                    }
                }
            }

            List<int> numbers = new List<int>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
            numbers.Add(2);

            for (int i = 1; i <= sieveBound; i++)
            {
                if (PrimeBits.Get(i))
                {
                    numbers.Add(2 * i + 1);
                }
            }

            return numbers.ToArray();

        }
        internal static void SumOfPrimes(long UpperLimit)
        {
            
        }
        public static void Main()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            LargestPrimeFactor(600851475143);
            stopwatch.Stop();
            Console.WriteLine("Elapsed time in milliseconds is: {0}", stopwatch.ElapsedMilliseconds);
            Console.ReadLine();
        }

    }
}
