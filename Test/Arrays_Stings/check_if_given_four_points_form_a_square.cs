using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class check_if_given_four_points_form_a_square
    {
        public check_if_given_four_points_form_a_square()
        {

        }
        bool isSquare(Point p1, Point p2, Point p3, Point p4)
        {
            int d1 = sqDist(p1, p2);
            int d2 = sqDist(p1, p3);

            int d3 = sqDist(p1, p4);


            if (d1 == d3 && 2 * d1 == sqDist(p2, p3) && (sqDist(p2, p3) == sqDist(p3, p4)))
                return true;

            return false;
        }

        int sqDist(Point p1,Point p2)
        {
            return ((p1.x - p2.x) * (p1.x - p2.x)) + ((p1.y - p2.y) * (p1.y - p2.y));
        }
    }

  


    class Point
    {
        public int x, y;
        Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
