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
        {   //reading the file, may need to cahnage directory of file depending on where it lives
            string filePath = @"C:\Users\WeCanCodeIT\Desktop\test.csv";

            List<string> lines = File.ReadAllLines(filePath).ToList();
           

            //Split lines into line items GUID, Val1, Val2, Val3
            List<LineItem> items = new List<LineItem>();

            foreach (string line in lines)
            {
                //Change Val1 and Val2 from string to int
                string[] entries = line.Replace('"', ' ').Trim().Split(',');
                int number;
                int number2;
                bool res = int.TryParse(entries[1], out number);
                bool res2 = int.TryParse(entries[2], out number2);


                LineItem newLineItem = new LineItem();

                newLineItem.Guid = entries[0];
                newLineItem.Val1 = number;
                newLineItem.Val2 = number2;
                newLineItem.Val3 = entries[3];

                items.Add(newLineItem);
                
            }

            //Count the lines
            int numberOfLines = 0;

            foreach (string line in lines)
            {
                numberOfLines++;
            }

            Console.WriteLine("Number of records in the file: " + numberOfLines);

            //Greatest sum of 2 vals, and Guid
            int sumOfVals;
            int greatestSum = 0;
            string correspondingGuid = null;
            foreach (var lineItem in items)
            {
                sumOfVals = lineItem.Val1 + lineItem.Val2;
                correspondingGuid = lineItem.Guid;
                if (sumOfVals >= greatestSum)
                {
                    greatestSum = sumOfVals;
                    correspondingGuid = lineItem.Guid;
                }

                
            }
            Console.WriteLine(correspondingGuid + greatestSum);


        }
    }
}
