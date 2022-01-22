using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole1_Jan
{
    class ListDemo
    {
        public static void ShowMe()
        {
            List<int> numberList = new List<int>();
            numberList.Add(32);
            numberList.Add(21);
            numberList.Add(45);
            numberList.Add(11);
            numberList.Add(89);
            for (int i = 0; i < numberList.Count; i++)
            {
                Console.WriteLine(numberList[i] + " ");
            }
            Console.WriteLine();

            foreach (int a in numberList)
                Console.WriteLine(a);
            // List of string
            List<string> authors = new List<string>(5);
            authors.Add("Mahesh Chand");
            authors.Add("Chris Love");
            authors.Add("Allen O'neill");
            authors.Add("Naveen Sharma");
            authors.Add("Monica Rathbun");
            authors.Add("David McCarter");
            foreach (string a in authors)
                Console.WriteLine(a);
        }
        public static void TraverseMe()
        {
        }
        public static void ReverseMe()
        {
            List<int> t = new List<int>();
            t.Add(45);
            t.Add(50);
            t.Add(55);
            t.Add(60);
            t.Add(70);
            int i;
            for (i = 0; i < t.Count(); i++)
                Console.WriteLine(t[i]);
            Console.WriteLine("Reverse of the List");
            for (i = t.Count()-1; i>=0; --i)
                Console.WriteLine(t[i]);

        }
    }
}
