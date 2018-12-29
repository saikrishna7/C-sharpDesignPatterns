using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    class Test
    {
        //public static void Main()
        //{
        //    Console.WriteLine("Enter first number");
        //    string input = Console.ReadLine();
        //    double num1, num2;

        //    bool result = Double.TryParse(input, out num1);
        //    if (!result)
        //    {
        //        Console.WriteLine("Please enter a number");
        //        return;
        //    }

        //    Console.WriteLine("Enter second number");
        //    input = Console.ReadLine();

        //    result = Double.TryParse(input, out num2);
        //    if (!result)
        //    {
        //        Console.WriteLine("Enter a number");
        //        return;
        //    }

        //    Console.WriteLine( " Enter Add, Subtract or Divide");
        //    CalculateFactory factory = new CalculateFactory();
        //    ICalculate ins = factory.GetCalculation(Console.ReadLine());
        //    ins.calculate(num1, num2);

        //}

        //Product(Page)
        //defines the interface of objects the factory method creates

        //ConcreteProduct(SkillsPage, EducationPage, ExperiencePage)
        //implements the Product interface
        
        //Creator  (Document)
        //declares the factory method, which returns an object of type Product.Creator may also define a default implementation of the factory method that returns a default ConcreteProduct object.
        //may call the factory method to create a Product object.
        
        //ConcreteCreator  (Report, Resume)
        //overrides the factory method to return an instance of a ConcreteProduct.

    }
}
