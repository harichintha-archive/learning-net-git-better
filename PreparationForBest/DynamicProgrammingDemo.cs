using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForBest
{
    class DynamicProgrammingDemo
    {
        //Fibonocci using recursive
        internal static int Fib(int n)
        {
            int result = 0;
            if (n == 1 || n == 2)
            {
                result = 1;
            }
            else
            {
                result = Fib(n - 1) + Fib(n - 2);
            }
            return result;
        }
        //Using Dynamic Programming
        internal static long Fib_Dynamic(int n,object[] ar)
        {
            if(ar[n] !=null)
            {
                return (long)ar[n];
            }
            if(n==1 || n == 2)
            {
                return 1;
            }
            else
            {
                ar[n] = Fib_Dynamic(n - 1, ar) + Fib_Dynamic(n - 2, ar);
                return (long)ar[n];
            }
        }
        //Using Bottom-Up
        internal static long Bottom_Up(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            long a = 1;
            long b = 1;
            long nth =a+b;
            for(int i = 3; i <= n; i++)
            {
                nth = a + b;
                a = b;
                b = nth;
            }
            return nth;
        }
        public static void Main()
        {
            Stopwatch s1 = new Stopwatch();
            s1.Start();
            int n = 1000;
            //Console.WriteLine(Fib(n));
           
            object[] ar = new object[n + 1];
            //Console.WriteLine(Fib_Dynamic(n, ar));
            Console.WriteLine(Bottom_Up(n));
            s1.Stop();
            Console.WriteLine(s1.ElapsedMilliseconds);
            Console.ReadLine();
        }
    }
}
