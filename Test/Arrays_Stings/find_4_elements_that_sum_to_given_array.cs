using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_4_elements_that_sum_to_given_array
    {
        public find_4_elements_that_sum_to_given_array()
        {
            int[] arr = { 10, 2, 3, 4, 5, 9, 7, 8 };
            int sum = 23;
            four_elements_are(arr, sum);
        }


        //{10, 2, 3, 4, 5, 9, 7, 8}
        void four_elements_are(int[] arr,int sum)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for(int i=0;i<arr.Length;i++)
            {
                dict.Add(i, arr[i]);
            }

            for(int i=1;i<arr.Length-2;i++)
            {
                int tempsum = sum;
              
                
                for(int j=2;j<arr.Length-1;j++)
                {
                    
                    for(int k=3;k<arr.Length;k++)
                    {
                       
                        if(tempsum-dict[i-1]-arr[i]-arr[j]-arr[k]==0)
                        {
                            Console.WriteLine(dict[i - 1] + "," + arr[i] + "," + arr[j] + "," + arr[k]);
                          
                        }
                              
                    }
                }
            }
        }
    }
}
