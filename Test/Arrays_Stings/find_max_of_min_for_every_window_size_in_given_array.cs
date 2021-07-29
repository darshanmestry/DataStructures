using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_max_of_min_for_every_window_size_in_given_array
    {
        /*
         Given an integer array of size n, find the maximum of the minimum’s of every window size in the array. 
        Note that window size varies from 1 to n.
        Example:

 
        Input: arr[] = {10, 20, 30, 50, 10, 70, 30} 
        Output: 70, 30, 20, 10, 10, 10, 10
        The first element in the output indicates the maximum of minimums of all 
        windows of size 1. 
        Minimums of windows of size 1 are {10}, {20}, {30}, {50}, {10}, 
        {70} and {30}. Maximum of these minimums is 70
        The second element in the output indicates the maximum of minimums of all 
        windows of size 2. 
        Minimums of windows of size 2 are {10}, {20}, {30}, {10}, {10}, 
        and {30}. Maximum of these minimums is 30
        The third element in the output indicates the maximum of minimums of all 
        windows of size 3. 
        Minimums of windows of size 3 are {10}, {20}, {10}, {10} and {10}. 
        Maximum of these minimums is 20
        Similarly, other elements of output are computed. 


         */
        public find_max_of_min_for_every_window_size_in_given_array()
        {
            int[] arr = { 10, 20, 30, 50, 10, 70, 30 };
            findres(arr);
        }

        void findres(int[] arr)
        {
            int len = arr.Length;
            
            // start from n-1 till 0 and store index of next smallest element 
            int[] leftSideSmaller = new int[len];
            Stack<int> st = new Stack<int>();

            for(int i=len-1;i>=0;i--)
            {
                while(st.Count>0 && arr[i] < arr[st.Peek()])
                {
                    
                    leftSideSmaller[st.Pop()] = i;
                }
            
                st.Push(i);
            }
            //fill remaining indexes of stack with -1;
            while(st.Count>0)
            {
                leftSideSmaller[st.Pop()] = -1;
            }


            //start from 0 till n-1 and store index of next smallest element 
            int[] rightSideSmaller = new int[len];
            st = new Stack<int>();

            for(int i=0;i<len;i++)
            {

                while(st.Count>0 && arr[i]<arr[st.Peek()])
                {
                    rightSideSmaller[st.Pop()] = i;
                }
                st.Push(i);
            }
            //fill remaining indexes of stack with Arr.Len;
            while (st.Count > 0)
            {
                rightSideSmaller[st.Pop()] = len; //this is main logic
            }

            int next = 0;
            int[] ans = new int[len+1 ];
            for (int i=0;i<len;i++)
            {
                // length of the interval
                int lenTemp =   rightSideSmaller[i] -  leftSideSmaller[i] -1;

               
                ans[lenTemp] = Math.Max(ans[lenTemp], arr[i]);

            }

            // Some entries in ans[] may not be
            // filled yet. Fill them by taking
            // values from right side of ans[]
            for (int i = len - 1; i >= 1; i--)
            {
                ans[i] = Math.Max(ans[i], ans[i + 1]);
            }

        }

        
    }
}
