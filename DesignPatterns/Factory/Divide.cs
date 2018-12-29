using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    class Divide : ICalculate
    {
        // The type of objects created will be decided by a separate factory class
        // Design patterns basic rule: Always program to the interface. 

        public void calculate(double a, double b)
        {
            Console.WriteLine("a/b is: {0}", a/b);
            Console.ReadLine();
        }

        
    }

    

    
}
