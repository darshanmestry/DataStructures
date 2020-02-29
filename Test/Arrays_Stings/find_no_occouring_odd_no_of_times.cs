using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_no_occouring_odd_no_of_times
    {
        public find_no_occouring_odd_no_of_times()
        {
            int[] arr = { 1, 2, 3, 2, 3, 1, 3 };

            findNo(arr);
        }

        void findNo(int[] arr)
        {
            int res = arr[0];

            for(int i=1;i<arr.Length;i++)
            {
                res = res ^ arr[i];
            }

            Console.WriteLine(res);

        }
    }
}
