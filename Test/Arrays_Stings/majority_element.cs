using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class majority_element
    {
        public majority_element()
        {
            /*
             * Write a function which takes an array and prints the majority element (if it exists), otherwise prints “No Majority Element”. 
             * A majority element in an array A[] of size n is an element that appears more than n/2 times (and hence there is at most one such element).
            Examples :

            Input : {3, 3, 4, 2, 4, 4, 2, 4, 4}
            Output : 4 

            Input : {3, 3, 4, 2, 4, 4, 2, 4}
            Output : No Majority Element

            Approach
            1. Find index of the element occuring max no of times using moores algo.
                    1.1 Moore voting algo
                        a.  check cur and prev elemt of array
                            if they are same then increment the cnt i.e. cnt++
                            else
                                cnt--;

                        b. if(cnt=0)
                                prev=i
                                cnt=1;
            2. Find occurenec count using of the elemt[index] got in previous step
            3
             */

            
            int[] arr1 = { 3, 3, 4, 2, 4, 4, 2, 4, 4 }; //case 1
            //majority(arr1);

            int[] arr2 = { 3, 3, 4, 2, 4, 4, 2, 4 };
            majority(arr2);



        }

        void majority(int[] arr)
        {
            int maj_index = 0, count = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[maj_index] == arr[i])
                    count++;
                else
                    count--;

                if (count == 0)
                {
                    maj_index = i;
                    count = 1;
                }
            }


            int countOfelement = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] == arr[maj_index])
                    countOfelement++;
            }

            if (countOfelement > (arr.Length / 2))
                Console.WriteLine(arr[maj_index]);
            else
                Console.WriteLine("Not possible"); 

        }
    }
}
