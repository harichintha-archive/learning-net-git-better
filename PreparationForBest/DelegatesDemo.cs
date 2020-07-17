using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForBest
{
    public delegate double CalAreaDel(int r);
    class DelegatesDemo
    {
        static void Main(string[] args)
        {
            //Using Delegates and method
            CalAreaDel cal0 = new CalAreaDel(CalArea);
            Console.WriteLine("Area is : {0}", cal0(12));

            //Anonymous Methods
            // no need to define a method
            CalAreaDel cal1 = new CalAreaDel( delegate(int r) { return 3.14 * r * r; });
            Console.WriteLine("Area is : {0}",cal1(12));

            //Using Lamda Expressiongs
            //no need to use delegate key word
            CalAreaDel cal2 = radius => radius * radius * 3.14;
            Console.WriteLine("Area is : {0}", cal2(12));

            //Using Lamda and Func delegate
            //We dont need to define a delegate
            //Func is a readymade delegate which takes any type of input(generic) and return anytype of output.
            Func<double, double> cal3 = radius => radius * radius * 3.14;
            Console.WriteLine("Area is : {0}", cal3(12));
            //Action is also a readymade generic delegate which takes only input parameters 
            Action<double> PrintSqr = Sqr => Console.WriteLine("Square of {0} is : {1}",Sqr,Sqr * Sqr);
            PrintSqr(13);
            //Predicate is also a generic delegate which takes any type of input and return only boolean
            Predicate<string> strCheck = str => str.Length > 10;
            Console.WriteLine("string is length is greater than 5: {0}", strCheck("121"));

            List<string> CustList = new List<string>();
           // CustList.Add("Hari Krishna");
            CustList.Add("Hari ");
            CustList.Add("Hari Krishna Chintha");
            CustList.Add(" Krishna");
            CustList.Add("Hari KC");
            CustList.Add("H Krishna");
            CustList.Add("Hari Ch");
            CustList.Add("Hari NOne");
            Console.WriteLine("Length greater than 10 chars: {0}",CustList.FindLast(s => s.Length > 12));
            Console.WriteLine("Is Present:{0} ",CustList.Any(s=>s=="Hari NOne"));

            Console.ReadLine();
        }
        public static double CalArea(int rad)
        {
            return 3.14 * rad * rad;
        }
    }
}
