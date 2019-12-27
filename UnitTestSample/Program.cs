using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ListIntersect objIntersect = new ListIntersect();
            List<string> data1 = new List<string> { "1","2", "3","4" };
            List<string> data2 = new List<string> { "6", "3","4" };
           var output= objIntersect.GetIntersect(data1, data2) ;

        }
    }
}
