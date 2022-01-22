using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole1_Jan
{
    class Factorial
    {
        public Factorial()
        { 
        }
        public void Fact1(int n)
        {
            int f = n;
            int k = 1;
            while(f>0)
            {
                k = k * f;
                f--;
            }
            Console.WriteLine("Factorial is:{0}", k);
        }
    }
}
