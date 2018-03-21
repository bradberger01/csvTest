using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvTest
{
    class LineItem
    {
        public string Guid { get; set; }
        public int Val1 { get; set; }
        public int Val2 { get; set; }
        public string Val3 { get; set; }
        public int numVal1 { get; set; }
        public int numVal2 { get; set; }

        //static LineItem FromTheLine(string line)
        //{
        //    var data = line.Split(',');

        //    return new LineItem()
        //    {
        //        Guid = data[0],
        //        Val1 = int.Parse(data[1]),
        //        Val2 = int.Parse(data[2]),
        //        Val3 = data[3],
        //    };
        //}

        //static int GetLargestSumOfVals()

       
        
    }

   
}
