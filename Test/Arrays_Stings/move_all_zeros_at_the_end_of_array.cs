using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class move_all_zeros_at_the_end_of_array
    {
        public move_all_zeros_at_the_end_of_array()
        {
            /*
             * Input :  arr[] = {1, 2, 0, 4, 3, 0, 5, 0};
                Output : arr[] = {1, 2, 4, 3, 5, 0, 0};

                Input : arr[]  = {1, 2, 0, 0, 0, 3, 6};
                Output : arr[] = {1, 2, 3, 6, 0, 0, 0};
             */

            int[] arr1= { 1, 2, 0, 4, 3, 0, 5, 0 }; ;
            move_zeros(arr1);
        }

        void move_zeros(int[] arr)
        {
            int count = 0;

            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]!=0)
                {
                    arr[count] = arr[i];
                    count++;
                }
            }

            for(int i=count;i<arr.Length;i++)
            {
                arr[i] = 0;
            }

            Console.Write("Done moving zeros");
        }
    }
}
