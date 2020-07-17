using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForBest._70_483
{
    class EventsAndCallBacksDemo
    {
        //using predifined delegetes Action -> no return type
        //Func -> has return type


        /// <summary>
        /// SockMerchant From HackersRank
        /// </summary>
        static int sockMerchant(int n, int[] ar)
        {
            int numberOfPairs = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int Sock in ar)
            {
                if (dict.ContainsKey(Sock))
                {
                    int currentValue = 0;
                    currentValue = dict[Sock];
                    currentValue++;
                    dict.Remove(Sock);
                    dict.Add(Sock, currentValue);
                }
                else
                {
                    dict.Add(Sock, 1);
                }
            }
            foreach (KeyValuePair<int, int> keyValuePair in dict)
            {
                numberOfPairs += keyValuePair.Value / 2;
            }
            return numberOfPairs;

        }
        /// <summary>
        /// Counting Valleys
        /// </summary>
        static int CountingValleys(int n, string s)
        {
            int numberOfValleys = 0;
            int Ds = 0;
            int Us = 0;
            foreach (char c in s)
            {
                if (c == 'D')
                {
                    Ds++;
                }
                if (c == 'U')
                {
                   
                }


            }
            return numberOfValleys;
        }

        internal static void FuncDemo()
        {
            Func<double, double, string> myFunc = (double a, double b) => (a + b).ToString();
            myFunc(42342.12, 232423.234);
        }
        public static void Main()
        {
            int[] ar = new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            Console.WriteLine(sockMerchant(9, ar));
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            // Declare second integer, double, and String variables.
            int j = Convert.ToInt16(Console.ReadLine());
            double e = Convert.ToDouble(Console.ReadLine());
            string s2 = Console.ReadLine();

            // Read and save an integer, double, and String to your variables.
            Console.WriteLine(i + j);
            // Print the sum of both integer variables on a new line.

            // Print the sum of the double variables on a new line.
            Console.WriteLine((decimal)(d + e));
            // Concatenate and print the String variables on a new line

            // The 's' variable above should be printed first.
            Console.WriteLine(s + s2);

            Console.ReadLine();
        }
    }
}
