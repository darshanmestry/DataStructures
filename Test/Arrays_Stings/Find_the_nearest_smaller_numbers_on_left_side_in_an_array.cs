using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class Find_the_nearest_smaller_numbers_on_left_side_in_an_array
    {
        public Find_the_nearest_smaller_numbers_on_left_side_in_an_array()
        {

        }

        void printneartest(int[] arr)
        {
            Stack<int> st = new Stack<int>();

            for(int i=0;i<arr.Length;i++)
            {

                if (st.Count == 0)
                    Console.Write("_,");

                st.Push(arr[i]);
            }
        }
    }
}
