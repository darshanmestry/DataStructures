using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class number_of_buildings_facing_sun
    {
        public number_of_buildings_facing_sun()
        {
            int[] arr = { 7, 4, 8, 2, 9 };
            find_biildings(arr);
        }

        void find_biildings(int[] arr)
        {
            

            int cur_max = arr[0];
            Console.Write(cur_max + " ");
            for(int i=1;i<arr.Length;i++)
            {
                if(arr[i]>cur_max)
                {
                    cur_max = arr[i];
                    Console.Write(cur_max + " ");
                }
            }
        }
    }
}
