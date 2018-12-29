using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BasicConcepts
{
    class A
    {
        public virtual void methodA()
        {
            Console.WriteLine( "A - MA" );
        }
    }

    class B: A
    {
        public override void methodA()
        {
            Console.WriteLine("B - MA");
        }

        public void methodB()
        {
            Console.WriteLine("B - MB");
        }
    }

    class Test
    {
        //static void Main()
        //{
        //    Console.WriteLine("A obj");
        //    A obj1 = new A();
        //    obj1.methodA();

        //    Console.WriteLine("B obj");
        //    B obj2 = new B();
        //    obj2.methodA();
        //    obj2.methodB();

        //    Console.WriteLine("A or B");
        //    // Super class obj = subclass obj
        //    int x = 10;
        //    // In above example x has value 10 but its property is integer. It can only accept integer values. Likewise 
        //    // in below example, obj3 has value of type 'B' but since it is of type 'A' it can access methods in class A. 
        //    // To see methods in 'B' cast the obj type to class 'B'
        //    A obj3 = new B();
        //    obj3.methodA();

        //    (obj3 as B).methodB();
        //    //((B)obj3).methodB();

        //    // cannot do this
        //    // sub class obj = superclass obj
        //    //B obj4 = new A();

        //    Console.ReadLine();
        //}
    }
}
