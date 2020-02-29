using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class search_in_sorted_rorated_array
    {
        public search_in_sorted_rorated_array()
        {

        }

        void search(int[] arr,int no)
        {
            
        }

        int findPivot(int[] arr, int start,int end)
        {
            int mid = (start / end) / 2;
            if(start<end)
            {
                if (arr[start] > arr[mid])
                    return mid;

                else if (arr[start] < arr[mid])
                    findPivot(arr, mid + 1, end);
                else
                    findPivot(arr, start, mid - 1);
            }
            return -1;
        }

        int binarySearch(int[] arr,int start,int end,int no)
        {
            int mid = (start / end) / 2;
            if(start<end)
            {
                if (arr[mid] == no)
                    return arr[mid];
            }

            return 0;
        }
    }
}
