using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class Maximum_Product_Subarray
    {
        //Input: arr[] = {6, -3, -10, 0, 2}
        public Maximum_Product_Subarray()
        {

        }

        void maxProd(int[] arr)
        {
            int maxProd = 1;
            int tempprod = 1;
            for(int i=0;i<arr.Length;i++)
            {
                tempprod = tempprod * arr[i];

                maxProd = Math.Max(tempprod, maxProd);

            }
        }
    }
}
