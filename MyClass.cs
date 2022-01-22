using System;
using System.Collections.Generic;
namespace TestConsole1_Jan
{
    class MyClass
    {
        public string myField = "Ganesh Sharma";

        public MyClass()
        {
        }

        public void MyMethod(int parameter1, string parameter2)
        {
            Console.WriteLine("First Parameter {0}, second parameter {1}",
                                                        parameter1, parameter2);
        }

        public int MyAutoImplementedProperty { get; set; }

        private int myPropertyVar;

        public int MyProperty
        {
            get { return myPropertyVar; }
            set { myPropertyVar = value; }
        }
    }
}
