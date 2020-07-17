using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForBest
{
    sealed class SingletonDemo
    {
        private SingletonDemo()
        {

        }
        private static readonly SingletonDemo _instance = new SingletonDemo();
        private static readonly Lazy<SingletonDemo> lazy = new Lazy<SingletonDemo>(() => new SingletonDemo());
        public static SingletonDemo Instance
        {
            get
            {
                return lazy.Value;
            }
        }
        public static SingletonDemo Instance2
        {
            get
            {
                return _instance;
            }
        }
        public  void Print()
        {
            Console.WriteLine("Hello dude");
        }
        public void isPrime(int N)
        {

        }
    }
    class SingletonProgramClass
    {
        static void Main(string[] args)
        {
            SingletonDemo s1 = SingletonDemo.Instance;
            s1.Print();
            Console.ReadLine();
        }
    }
}
