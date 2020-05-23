using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_no_of_triangles
    {
        public find_no_of_triangles()
        {
            int[] arr = { 4, 6, 3, 7 };
            no_of_triangles(arr);
        }

        /*
         * if the input array is {4, 6, 3, 7}, the output should be 3. 
         * There are three triangles possible {3, 4, 6}, {4, 6, 7} and {3, 6, 7}. 
         * Note that {3, 4, 7} is not a possible triangle.
         *  
         *  {3,4,6,7}
         */
        void no_of_triangles(int[] arr)
        {
            int count=0;
            Array.Sort(arr);

            for(int i=0;i<arr.Length-2;i++)
            {
                int k = i + 2;
                for(int j=i+1;j<arr.Length;j++)
                {
                    while(k<arr.Length && (arr[i]+arr[j])>arr[k])
                    {
                     
                        k++;
                    }

                    if (k > j)
                        count += k - j - 1;

                }              
            }

            Console.WriteLine(count);

        }
    }
}
