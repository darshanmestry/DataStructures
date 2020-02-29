using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_missing_no
    {
        public find_missing_no()
        {
            int[] arr = { 1, 2, 3, 5 };

            missingNo(arr);
        }

        void missingNo(int[] arr)
        {
            int res = ((arr.Length +1)* (arr.Length + 2))/2  ;

            for(int i=0;i<arr.Length;i++)
            {
                res -= arr[i];
            }

            Console.WriteLine(res);
        }
    }
}
