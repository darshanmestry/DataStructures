using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class overlapping_rectangles
    {
        public overlapping_rectangles()
        {
            point l1 = new point(10,10);
            point r1 = new point(10, 10);
            point l2 = new point(10, 10);
            point r2 = new point(10, 10);

            Console.WriteLine(isOverlap(l1,r1,l2,r2));
     }
        bool isOverlap(point l1, point r1, point l2, point r2)
        {
            if (l1.x > r2.x || l2.x > r1.y)
                return false;


            if (l1.y < r2.y || l2.y < r1.y)
                return false;

            return true;


        }
    }

    

    class point
    {
       public  int x, y;
        public point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
