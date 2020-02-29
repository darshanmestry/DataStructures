using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class Equibilirium_index_of_an_Array
    {
        public Equibilirium_index_of_an_Array()
        {
            int[] arr = { -7, 1, 5, 2, -4, 3, 0};

            Console.WriteLine(indexOFArray(arr));
        }

        int indexOFArray(int[] arr)
        {
            int leftindex = 0;
            int rightindex = arr.Length - 1;

            int leftsum=0, rightsum=0;

            for(int i=0; i<arr.Length;i++)
            {
                if (leftindex + i <= rightindex - i)
                {
                    leftsum += arr[leftindex + i];
                    rightsum += arr[rightindex - i];

                    if (leftsum == rightsum)
                        return (leftindex + i + 1);

                }
            }
            return -1;
        }
    }
}
