using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    public class petrolPump
    {
        public int petrol;
        public int distance;

        public petrolPump(int petrol,int distance)
        {
            this.petrol = petrol;
            this.distance = distance;
        }
    }
    class find_tour_that_visits_all_stations
    {
        public find_tour_that_visits_all_stations()
        {
            /*
              Suppose there is a circle. There are n petrol pumps on that circle. You are given two sets of data.
               The amount of petrol that every petrol pump has.
               Distance from that petrol pump to the next petrol pump.
               Calculate the first point from where a truck will be able to complete the circle
               (The truck will stop at each petrol pump and it has infinite capacity). 
               Expected time complexity is O(n). Assume for 1-litre petrol, the truck can go 1 unit of distance.


            petrolPump p1 = new petrolPump(4,6);
            petrolPump p2 = new petrolPump(6,5);
            petrolPump p3 = new petrolPump(7,3);
            petrolPump p4 = new petrolPump(4,5);
            */
            petrolPump p1 = new petrolPump(4, 6);
            petrolPump p2 = new petrolPump(6, 5);
            petrolPump p3 = new petrolPump(7, 3);
            petrolPump p4 = new petrolPump(4, 5);
           


            List<petrolPump> list = new List<petrolPump>();
            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);

            int res=find_dist(list);
        }

        int find_dist(List<petrolPump> list)
        {
            int start = 0, end = 1;
            int cur = (list.ElementAt(start).petrol - list.ElementAt(start).distance);


            // If current amount of petrol in 
            // truck becomes less than 0, then
            // remove the starting petrol pump from tour
            while (end!=start && cur<0)
            {
                // If current amount of petrol in
                // truck becomes less than 0, then
                // remove the starting petrol pump from tour
                while (end!=start && cur<0)
                {
                    // Remove starting petrol pump.
                    // Change start
                    cur = cur-(list.ElementAt(start).petrol- list.ElementAt(start).distance);

                    start = (start + 1) % list.Count;


                    // If 0 is being considered as
                    // start again, then there is no
                    // possible solution
                    if (start==0)
                    {
                        return -1;
                    }
                }

                
                petrolPump node = list.ElementAt(end);

                // Add a petrol pump to current tour
                cur += list.ElementAt(end).petrol - list.ElementAt(end).distance;

                end = (end + 1) % list.Count;

            }

            return start;
            //int end = 1, start = 0;

            //int cur = 0;
            //int itr = 0;
            //while(true)
            //{

            //    Console.WriteLine("Checking index " + start);
            //    petrolPump obj = list.ElementAt(start);

            //    cur = cur+ (obj.petrol - obj.distance);

            //    if (cur < 0)
            //    {
            //        cur = 0;
            //        itr = 0;
            //        start++;
            //    }
            //    else
            //    {
            //        itr++;
            //        start++;
            //    }

                
            //    //if (start != 0 ? start + 1 == end : start == end)
            //    //    break;

            //    if (start > list.Count - 1)
            //        start = 0;

            //    if (itr == list.Count)
            //        break;
            //}

            //if (cur>=0)
            //{
            //    int res = end + 1;
            //}

        }
    
        int practise(List<petrolPump> list)
        {
            int start = 0, end = 1;

            int cur = list.ElementAt(start).petrol - list.ElementAt(start).distance;

            while(start!=end && cur <0)
            {
                while(start!=end && cur<0)
                {
                    cur-= list.ElementAt(start).petrol - list.ElementAt(start).distance;

                    start = (start + 1) % list.Count;

                    if (start == 0)
                        return -1;

                }

                 cur = list.ElementAt(end).petrol - list.ElementAt(end).distance;

                 end = (end + 1) % list.Count;


            }

            return start;
        }
    }
}
