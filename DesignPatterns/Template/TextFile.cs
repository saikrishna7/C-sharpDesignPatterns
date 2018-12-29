using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Template
{
    class TextFile : DataProcessor
    {
        

        public override void ReadData()
        {
            Console.WriteLine("Reading data from text file");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Process data in text file");
        }

        
    }
}
