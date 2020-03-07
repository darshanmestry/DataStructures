using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class calculate_maximun_point_on_same_line
    {
        public calculate_maximun_point_on_same_line()
        {
            Point p1 = new Point(-1, 1);
            Point p2 = new Point(0, 0);
            Point p3 = new Point(1, 1);
            Point p4 = new Point(2, 2);
            Point p5 = new Point(3, 3);
            Point p6 = new Point(3, 4);
            List<Point> PointList = new List<Point>();


            PointList.Add(p1);
            PointList.Add(p2);
            PointList.Add(p3);
            PointList.Add(p4);
            PointList.Add(p5);
            PointList.Add(p6);

            pointsCount(PointList);
        }


        void pointsCount(List<Point> pointList)
        {
            Dictionary<double, List<Point>> dict = new Dictionary<double, List<Point>>();

            //double dd = 4 / (double)3;
            HashSet<Point> ht = new HashSet<Point>();

            int max = int.MinValue;
            for(int i=0;i<pointList.Count-2;i++)
            {
                for(int j=i+1;j<pointList.Count;j++)
                {
                    Point p1 = pointList.ElementAt(i);
                    Point p2 = pointList.ElementAt(j);

                    Double slope = ((p2.y - p1.y) / (double)(p2.x - p1.x));

                    if (slope == 0) //slope is 0 it means it is a horizantal line 
                        continue;

                   // string str = "(" + p1.x.ToString() + "," + p1.y.ToString() + ") ,(" + p2.x.ToString() + "," + p2.y.ToString() + ")"; 

                   // string str2= "(" + p2.x.ToString() + "," + p2.y.ToString() + ") ,(" + p1.x.ToString() + "," + p1.y.ToString() + ")";

                   
                   if (!dict.ContainsKey(slope))
                   {
                        List<Point> plist = new List<Point>();
                        if (!plist.Contains(p1))
                            plist.Add(p1);
                        if (!plist.Contains(p2))
                            plist.Add(p2);

                        dict.Add(slope, plist);
                        max = Math.Max(plist.Count, max);

                    }
                    else
                    {
                        List<Point> plist = dict[slope];

                        if (!plist.Contains(p1))
                            plist.Add(p1);
                        if (!plist.Contains(p2))
                            plist.Add(p2);

                        max = Math.Max(plist.Count, max);

                    }
                    
               
                }
            }
            Console.WriteLine(max);
        }
    }
}
