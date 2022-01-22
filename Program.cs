using System;
using TestConsole1_Jan.Loops;

namespace TestConsole1_Jan
{
    class Program
    {
        static void kundvenkat()
        {
            Console.WriteLine("I am kundvanket");
        }
        static void Main(string[] args)
        {

            oddEven o = new oddEven();
            o.showNum(6);

            //Factorial fact = new Factorial();
            //fact.Fact1(5);
            //MyClass m = new MyClass();
            //Console.WriteLine("Field value is {0}", m.myField);
            //m.MyProperty = 20;
            //Console.WriteLine("Your Value:" + m.MyProperty);
        }
    }
    class Box
    {
        private int length;
        private int width;
        public int CalculateArea(int l,int w)
        {
            int area = l * w;
            Console.WriteLine("Area= "+ area);
            return area;
        }
    }
}
