using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSVHandling
{
    class CsvWriter
    {
        public static void writeCsvNoStreamWriter()
        {
            string filepath = @"C:\Users\vande\Documents\VDAB opleiding\DemoData.csv";
            StringBuilder output = new StringBuilder();
            output.AppendLine("1,2,3");
            output.AppendLine("4,5,6");

            File.WriteAllText(filepath, output.ToString());
            File.AppendAllText(filepath, output.ToString());
        }
        public static void writeCsvStreamWriter()
        {
            using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\vande\Documents\VDAB opleiding\DemoData.csv"))
            {
                streamWriter.WriteLine("1,2,3");
                streamWriter.WriteLine("4,5,6");
            }
        }
    }
}