using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class sum_of_bit_differences_among_all_pairs
    {
        public sum_of_bit_differences_among_all_pairs()
        {
            int[] arr = { 1, 3, 5 };
            int res = solution(arr);
        }

        int solution(int[] arr)
        {

            int ans = 0;
            
            //Step 1: Assume each no is to be represented in binary  with fixed set of bits,here we are assiming 32 bits,if all nos are less than 1000 then we can use 8 bits instead of 32
            for(int i=0;i<32;i++)
            {
                int cnt = 0;
                //Step 2: Itreate the Input array
                for(int j=0;j<arr.Length; j++)
                {
                    //Step 3:we check how many bits are set in the right most bit, For. e.g as we are using 32 bits to represent a no
                    // we will check if 0th bit is unset of all the nos and keep cnt in 1st ir
                    // in 2nd Its we will check 1st bit of all the nos and keep count of how many bits are unset/
                    if ((arr[j] & (1 << i)) == 0)
                        cnt++;
                }

                //Step: 4
                //formula to count set bit of pais is   (No_of_SET_BITS_AT_EVERY_POSITION * No_of_UNSET_BITS_AT_EVERY_POSITION )*2
                //i.e. ( Count * (arr.length-count) ) *2 Note: arr.Length-count gives total no of bits which are not set
                ans += cnt * (arr.Length - cnt) * 2;
            }
            return ans;
        }
    }
}
