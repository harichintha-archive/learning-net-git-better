using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForBest
{
    class Program
    {
        public static void PrimeNumber()
        {
            Console.WriteLine("Enter a number : ");
            int n = int.Parse(Console.ReadLine());

            bool flag = true;
            for (int i = 2; i < n; i++)
            {
                flag = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag == true)
                {
                    Console.Write(i + " ");
                }
            }
        }
        public static void PolindromeDemo()
        {
            Console.WriteLine("Enter a Number:");
            long m = int.Parse(Console.ReadLine());
            long n = m;
            long temp, res=0;
            while (n > 0)
            {
                temp = n % 10;
                res = (res*10) + temp;
                n = n / 10;
            }
            if (res == m)
            {
                Console.WriteLine("Given number is a Polindrome");
            }
            else
            {
                Console.WriteLine("Given number is NOT Polindrome");
            }
        }
        public static long FactorialDemo(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * FactorialDemo(n - 1);
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FactorialDemo(5));
            Console.ReadLine();
        }
    }
}
