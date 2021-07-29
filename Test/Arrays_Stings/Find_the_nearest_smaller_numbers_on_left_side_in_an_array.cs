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
        {// Create an empty stack
            Stack<int> S = new Stack<int>();

            // Traverse all array elements
            for (int i = 0; i < arr.Length; i++)
            {
                // Keep removing top element from S while the top
                // element is greater than or equal to arr[i]
                while (S.Count != 0 && S.Peek() >= arr[i])
                {
                    S.Pop();
                }

                // If all elements in S were greater than arr[i]
                if (S.Count == 0)
                {
                    Console.Write("_, ");
                }
                else //Else print the nearest smaller element
                {
                    Console.Write(S.Peek() + ", ");
                }

                // Push this element
                S.Push(arr[i]);
            }
        }
    }
}
