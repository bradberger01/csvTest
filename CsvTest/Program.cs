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

            int numberOfLines = 0;

            foreach (string line in lines)
            {
                numberOfLines++;
            }
            numberOfLines = numberOfLines - 1;
            //Because top line are names of items not records
            Console.WriteLine("Number of records in the file: " + numberOfLines);

            List<LineItem> items = new List<LineItem>();

            foreach (string line in lines)
            {
                string[] entries = line.Split(',');

                LineItem newLineItem = new LineItem();

                newLineItem.Guid = entries[0];
                newLineItem.Val1 = entries[1];
                newLineItem.Val2 = entries[2];
                newLineItem.Val3 = entries[3];

                items.Add(newLineItem);
            }

            foreach (var lineItem in items)
            {
                Console.WriteLine($"{lineItem.Guid}");
            }
        }
    }
}
