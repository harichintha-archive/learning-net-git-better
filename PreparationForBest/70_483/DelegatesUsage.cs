using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreparationForBest._70_483
{
    class DelegatesUsage
    {
        public delegate int Calculations(int i, int j);

        public int Add(int x,int y)
        {
            Console.WriteLine("Adding x, y ");
            return x + y;
        }
        public DelegatesUsage()
        {
            Calculations calc = (int x, int y) => x + y;
            calc(5, 6);
           
        }
    
    }
}
