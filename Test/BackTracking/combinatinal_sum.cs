using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.BackTracking
{
    class combinatinal_sum
    {
        List<string> list = new List<string>();

        public combinatinal_sum()
        {
            int[] arr = { 2, 4, 6, 8 };
            int x = 8;

            calcuate_sum(arr, x);

           list=list.OrderBy(i => i).ToList();

        }

        void calcuate_sum(int[] arr,int x)
        {
            for(int i=0;i<arr.Length;i++)
            {
                util(arr, 1, arr[i], x);
                Console.WriteLine();
            }
        }

        bool util(int[] arr, int elem_cnt,int no,int x)
        {

            if(elem_cnt * no==x)
            {
                string str = "";
                for (int i = 0; i < elem_cnt; i++)
                {
                    str += no.ToString() + " ";
                   
                }
                if (!list.Contains(str)) 
                    list.Add(str);
                return true;
            }

            if (elem_cnt * no > x)
                return false;

            int rem_no = (x - (elem_cnt * no));

            if (elem_cnt * no < x && search(arr, rem_no))
            {
                string str = "";
                for (int i = 0; i < elem_cnt; i++)
                {
                    str += no.ToString() + " ";
                    

                }

                str += rem_no.ToString()+" ";

                if (!list.Contains(str))
                    list.Add(str);
            }

            if (util(arr, elem_cnt + 1, no, x))
            {
                return true;
            }

            return false;
        }

        bool search(int[] arr,int no)
        {

            int index = binarysearch(arr, 0, arr.Length - 1, no);

            if (index == -1)
                return false;
            else
                return true;
        }


        int binarysearch(int[] arr,int start,int end,int no)
        {
            if(start<=end)
            {
                int mid = (start + end) / 2;

                if (arr[mid] == no)
                    return mid;

                else if (no > arr[mid])
                   return  binarysearch(arr, mid + 1, end, no);
                else
                   return  binarysearch(arr, start, mid - 1, no);
            }
            return -1;
        }
    }
}
