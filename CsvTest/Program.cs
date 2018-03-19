using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CsvTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\WeCanCodeIT\Desktop\test.csv";

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

        }
    }
}
