using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_maximum_sum_subarray
    {
        public find_maximum_sum_subarray()
        {

        }

        void printMaxSubArray(int[] arr)
        {
            int maxSofar=0, maxEndshere=0;

            if(arr.Length>0)
            maxSofar = arr[0];


            for(int i=0;i<arr.Length;i++)
            {
                maxEndshere = maxEndshere + arr[i];
                if(maxEndshere>maxSofar)
                {
                    maxSofar = maxEndshere;
                }
                
                if(maxEndshere<0)
                {
                    maxEndshere = 0;
                }
            }
        }
    }
}
