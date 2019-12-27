using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSample
{
    public class ListIntersect
    {
        public List<string> GetIntersect(List<string> listA, List<string> listB )
        {
            var intersectData = listA.Intersect(listB).ToList();
            return intersectData;
        }
    }
}
