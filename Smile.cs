using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole1_Jan
{
    class Smile
    {
        public void Abc()
        {
            Console.Write("===========================");
            Console.Write("He...He.....He...He....");
            Console.WriteLine("========================");
        }

        public void Testloop1()
        {
            string username = Console.ReadLine();
            for(int i=1;i<10;i++)
            {
                Console.WriteLine("Hello {0}",username);
            }
        }
        public void Testloop2()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("");
            }
        }
    }
}
