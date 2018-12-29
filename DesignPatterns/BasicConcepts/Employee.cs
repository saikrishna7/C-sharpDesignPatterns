using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BasicConcepts
{
    // Sample pgm demonstrating when to use constructor, hard coding and setter method for setting values. 
    class Employee
    {
        // if you want objects to be created with a minimum set of values then set them inside constructor.
        // Declare important variables as private. Anything that can be modified later can be declared public. 
        private int empId;
        private string empName;

        // salary and grade can be set using getter and setter methods 
        public int empSal { get; set; }
        public int grade { get; set; }

        // values which will be same for every object can be hard coded.
        public string company = "IBM";

        IEmail email;

        public Employee(int empId, string empName, IEmail email)
        {
            this.empId = empId;
            this.empName = empName;
            this.email = email;
        }

        public void NotifyEmployee()
        {
            email.sendEmail();
        }

    }

    class TestEmployee
    {
        //static void Main()
        //{
        //    IEmail email = new OutlookEmail();
        //    Employee emp1 = new Employee(100, "Sai",email);
        //    emp1.empSal = 100000;
        //    emp1.NotifyEmployee();

        //    email = new WebserviceEmail();
        //    Employee emp2 = new Employee(101, "Krishna",email);
        //    emp2.NotifyEmployee();

        //    Console.WriteLine(emp1);
        //    Console.WriteLine(emp2);
        //    Console.ReadLine();
        //}
        
        
    }
}
