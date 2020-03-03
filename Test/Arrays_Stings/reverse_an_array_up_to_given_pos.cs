using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class reverse_an_array_up_to_given_pos
    {
        /**
         * Input:
        arr[] = {1, 2, 3, 4, 5, 6}
            k = 4

        Output:
        arr[] = {4, 3, 2, 1, 5, 6} 
         * **/
        public reverse_an_array_up_to_given_pos()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            rev_Array(arr, 4);
        }

        void rev_Array(int[] arr,int pos)
        {
            if (pos > arr.Length)
                Console.WriteLine("Not Possible");


            for(int i=0;i<pos/2;i++)
            {
                int temp = arr[i];
                arr[i] = arr[pos - i - 1];
                arr[pos - i - 1] = temp;
            }

            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
