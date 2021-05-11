using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class next_smallest_palindrome_larger_than_no
    {
        /*
         Given a number, find the next smallest palindrome
        Given a number, find the next smallest palindrome larger than this number. For example, 
        if the input number is “2 3 5 4 5”, the output should be “2 3 6 3 2”. 
        And if the input number is “9 9 9”, the output should be “1 0 0 1”.
        The input is assumed to be an array. Every entry in array represents a digit in input number. 
        Let the array be ‘num[]’ and size of array be ‘n’

        There can be three different types of inputs that need to be handled separately.
        1) The input number is palindrome and has all 9s. For example “9 9 9”. Output should be “1 0 0 1”
        2) The input number is not palindrome. For example “1 2 3 4”. Output should be “1 3 3 1”
        3) The input number is palindrome and doesn’t have all 9s. For example “1 2 2 1”. Output should be “1 3 3 1”
         */
        public next_smallest_palindrome_larger_than_no()
        {
            //Case 1: Odd len no
            int[] arr1 = { 2, 3, 5, 4, 5 }; 
            next_palindrome(arr1);


            //Case 2: even len no
            int[] arr2 = { 1, 2, 3, 4 };
            //next_palindrome(arr2);

            //Case 3: already palindrome
            int[] arr3 = { 1, 2, 2, 1 };
            next_palindrome(arr3);


        }

       void next_palindrome(int[] arr)
       {
            /*
             Steps to follow
            1.
             */
            bool isOdd = false;
            //fill all array elements in temp
            int[] temp = new int[arr.Length];

            for(int k=0;k<arr.Length;k++)
            {
                temp[k] = arr[k];
            }

            //calculate mid len
            int mid = arr.Length / 2;

            int i, j;
            
            
            if(arr.Length%2!=0)
            {
                isOdd = true;
                i = j = mid;
            }
            else
            {
                i = mid - 1;
                j = mid;
            }


            while(i>=0 && j<arr.Length)
            {
                if(arr[i]!=arr[j])
                {
                    arr[j] = arr[i];
                }
                i--;
                j++;
            }

            int no = getNo_alternative(temp);
            if(getno(temp)>=getno(arr))
            {
                arr[mid]++;
                if (!isOdd)
                {
                    arr[mid - 1]++;
                } 
            }

            

       }

        int getno(int[] arr)
        {

            int place = 0;
            int no = 0; ;
            for(int i=arr.Length-1;i>=0;i--)
            {
                no += (int)Math.Pow(10,place)*arr[i];

                place++;
            }

            return no;
        }

        int getNo_alternative(int[] arr)
        {
            int res = 0;

            for(int i=0;i<arr.Length;i++)
            {
                res = (res * 10) + arr[i];
            }

            return res;
        }
    }
}
