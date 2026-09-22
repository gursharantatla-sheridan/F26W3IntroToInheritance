using System;
using System.Collections.Generic;
using System.Text;

namespace F26W3IntroToInheritance
{
    public class BaseClass
    {
        private int myPrivateVar;
        protected int myProtectedVar;
        public int myPublicVar;

        // constructor
        //public BaseClass()
        //{
        //    Console.WriteLine("Base class constructor called");
        //}

        public BaseClass(string msg)
        {
            Console.WriteLine("Base class constructor with message: " + msg);
        }
    }

    public class DerivedClass : BaseClass
    {
        //constructor
        public DerivedClass(string msg) : base(msg)
        {
            Console.WriteLine("Derived class constructor called");
        }

        public void MyMethod()
        {
            //myPrivateVar = 1;
            myProtectedVar = 2;
            myPublicVar = 3;
        }
    }
}
