using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Template
{
    public abstract class DataProcessor
    {
        public void ReadProcessandSave()
        {
            ReadData();
            ProcessData();
            SaveData();
        }

        public abstract void ReadData();
        public abstract void ProcessData();

        public void SaveData()
        {
            Console.WriteLine("Saving data to DB");
        }
    }
}
