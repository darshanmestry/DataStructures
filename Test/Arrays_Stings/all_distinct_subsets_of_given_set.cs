using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class all_distinct_subsets_of_given_set
    {
        public all_distinct_subsets_of_given_set()
        {
            /*
             * Input:  S = {1, 2, 2}
                Output:  {}, {1}, {2}, {1, 2}, {2, 2}, {1, 2, 2}

                Explanation: 
                The total subsets of given set are - 
                {}, {1}, {2}, {2}, {1, 2}, {1, 2}, {2, 2}, {1, 2, 2}
                Here {2} and {1, 2} are repeated twice so they are considered 
                only once in the output
             */

            int[] arr = { 1, 2, 2 };
            subsets_Easy_solution(arr);
            subsets(arr);
        }

        void subsets(int[] arr)
        {
           
            int n = (int)Math.Pow(2, arr.Length);
            List<string> lis = new List<string>();

            for(int i=0;i<n;i++)
            {
                string temp = "";
                for (int j=0;j<arr.Length;j++)
                {

                    // for every bit of i which is not set add the elements to the temp
                    if((i &(1<<j))!=1)
                    {

                        temp += arr[j].ToString() + " ";

                    }

                    if (!lis.Contains(temp))
                        lis.Add(temp);
                }
               
            }
        }
    
    

        void subsets_Easy_solution(int [] arr)
        {
            int pow = (int)Math.Pow(2, arr.Length);

            List<string> lis = new List<string>();

            for(int i=0;i<pow;i++)
            {
                string temp = "";

                // consider each element in the set
                for (int j=0;j<arr.Length;j++)
                {

                    // Check if jth bit in the i is set. If the bit
                    // is set, we consider jth element from set
                    if ((i&(1<<j))!=0)
                    {
                        temp += arr[j].ToString();
                    }

                    if (!lis.Contains(temp))
                        lis.Add(temp);
                }
            }
        }
        void pract(int[] arr)
        {
            int pow =(int) Math.Pow(2, arr.Length);
            List<string> lis = new List<string>();
            for (int i=0;i<pow;i++)
            {
                string temp = "";
                for(int j=0;j<arr.Length;j++)
                {
                    
                    if((i & (1<<j ))!=1)
                    {
                        temp += arr[j] + " ";
                    }

                    if (!lis.Contains(temp))
                        lis.Add(temp);
                }
            }
        }
    }
}
