using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class rearrange_posotive_and_negative_nos_OofN_time_O1_extraspace
    {
        public rearrange_posotive_and_negative_nos_OofN_time_O1_extraspace()
        {
            int[] arr={-1, 2, -3, 4,5, 6, -7, 8, 9};
            //For example, if the input array is [-1, 2, -3, 4, 5, 6, -7, 8, 9], then the output should be [9, -7, 8, -3, 5, -1, 2, 4, 6]
            //rearrange(arr);
            rearrange_Practise(arr);
        }


        void rearrange_Practise(int[] arr)
        {
            int index = 0;

            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]<0)
                {
                    int temp = arr[index];
                    arr[index] = arr[i];
                    arr[i] = temp;
                    index++;
                }
            }

            int posIndex = index, negIndex = 0;

            while(posIndex<arr.Length )
            {
                if (arr[negIndex] < 0)
                {
                    int temp = arr[negIndex];
                    arr[negIndex] = arr[posIndex];
                    arr[posIndex] = temp;
                   
                }
                posIndex += 2;
                negIndex += 2;

            }
        }

      

        void  rearrange(int[] arr)
        {
            int pivot = arr.Length - 1;
            int i = 0;

            while(i<=pivot)
            {
                if(arr[i]< 0)
                {
                   
                    int temp = arr[i];
                    arr[i] = arr[pivot];
                    arr[pivot] = temp;
                    pivot--;
                }
                i++;
            }

            int tmp_pivot=pivot;
            pivot++;
            int j = 0;

            while(j<=pivot-1 && pivot<=arr.Length-1)
            {
                Console.Write(" "+arr[j] + " " + arr[pivot]);
                j++;
                pivot++;
            }

            if(j!=tmp_pivot)
            {
                while(j<=tmp_pivot)
                {
                    Console.Write(" "+arr[j] + " ");
                    j++;
                }
                
            }
            if(pivot!=arr.Length-1)
            {
                while(pivot<=arr.Length-1)
                {
                    Console.Write(" "+arr[pivot]+" ");
                    pivot++;
                }
            }
        }

        void swap(int a,int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
