using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class CalculateFactory
    {
        public ICalculate GetCalculation(string type)
        {
            ICalculate instance = null;

            if (type.ToLower().Equals("add"))
            {
                instance = new Add();
            }
            else if (type.ToLower().Equals("subtract"))
            {
                instance = new Subtract();
            }
            else if (type.ToLower().Equals("divide"))
            {
                instance = new Divide();
            }
            else
            {
                Console.WriteLine("We don't do that");
            }
            return instance;
        }
    }
}
