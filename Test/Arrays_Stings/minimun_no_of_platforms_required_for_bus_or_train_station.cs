using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    /*
     * Given the arrival and departure times of all trains that reach a railway station, the task is to
     * find the minimum number of platforms required for the railway station so that no train waits. 
        We are given two arrays that represent the arrival and departure times of trains that stop.

        Examples: 

        Input: arr[] = {9:00, 9:40, 9:50, 11:00, 15:00, 18:00} 
        dep[] = {9:10, 12:00, 11:20, 11:30, 19:00, 20:00} 
        Output: 3 
        Explanation: There are at-most three trains at a time (time between 11:00 to 11:20)

        Input: arr[] = {9:00, 9:40} 
        dep[] = {9:10, 12:00} 
        Output: 1 
        Explanation: Only one platform is needed. 
     */
    class minimun_no_of_platforms_required_for_bus_or_train_station
    {
        public minimun_no_of_platforms_required_for_bus_or_train_station()
        {
            int[] arr = { 900, 940, 950, 1100, 1500, 1800 };
            int[] dep = { 910, 1200, 1120, 1130, 1900, 2000 };
           
            solve_train_platform(arr, dep);
        }

        void solve_train_platform(int[] arr,int[] dep)
        {
            //step 1: Sort arrival and departure array in ascending order
            Array.Sort(arr);
            Array.Sort(dep);

            //Step 2: point i to 1st element of arr and J to 0th element of dep

            int i = 1;
            int j = 0;

            //Step 3: Run a look till i or J reach end of thelist i.e arr.length or dep.length in this case both arrays will be having same length
            int len = arr.Length;

            //this will store max while iterating arr[] and dep[]
            int platform_needed = 1;

            //this will store our final ans
            int result = 1;
            while(i<len && j<len)
            {
                //Step 4: Compare arrival time [i] with departure time[j]
                //        There can be 2 cases 
                //                              case 1: arr[i] > dep[j] : It means there is no overlapping of timings. Hence Increment j and Decrement max by 1
                //                              case 2: arr[i] < dep[j] : It means there is overlapping of timings. Hence Increment i and  platform_needed by 1. 
                //                                                        And if platform_needed > result then set result=platform_needed;


                if (arr[i]>=dep[j])
                {
                    j++;
                    platform_needed--;
                }
                else if(dep[j]>=arr[i])
                {
                    i++;
                    platform_needed++;
                }

                if (platform_needed > result)
                    result = platform_needed;
            }

        }

    }
}
