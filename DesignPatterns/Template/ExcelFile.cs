using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Template
{
    class ExcelFile: DataProcessor
    {
        

        public override void ReadData()
        {
            Console.WriteLine("Reading data from excel file");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Process data in excel file");
        }

        
    }
}
