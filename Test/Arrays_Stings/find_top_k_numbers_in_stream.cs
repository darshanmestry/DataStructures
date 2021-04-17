using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_top_k_numbers_in_stream
    {
        /*
         * Find top k (or most frequent) numbers in a stream
         * Given an array of n numbers. Your task is to read numbers from the array and keep at-most K numbers at the top (According to their decreasing frequency) every time a new number is read. We basically need to print top k numbers sorted by frequency when input stream has included k distinct elements, else need to print all distinct elements sorted by frequency.

            Examples:

            Input :  arr[] = {5, 2, 1, 3, 2}
                         k = 4
            Output : 5 2 5 1 2 5 1 2 3 5 2 1 3 5 

            Input  : arr[] = {5, 2, 1, 3, 4}
                         k = 4
            Output : 5 2 5 1 2 5 1 2 3 5 1 2 3 4
            Expected time complexity is O(n * k)
                     */
        public find_top_k_numbers_in_stream()
        {
            int[] arr = { 5, 2, 1, 3, 4 };
            int k = 4;
            practise(arr, k);
            print_stream_implement(arr, k);
            print_stream(arr, k);
        }

        // Implemented by me
        void print_stream_implement(int[] arr,int k)
        {
            int[] top = new int[k + 1];

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i <= k + 1; i++)
                dict.Add(i, 0);

            for(int i=0;i<arr.Length;i++)
            {
                if (dict.ContainsKey(arr[i]))
                    dict[arr[i]]++;
                else
                    dict.Add(arr[i], 1);


                top[k] = arr[i];

                int temp_k = k;
                temp_k--;
                int j = temp_k;

                while(j>=0)
                {
                    if (dict[top[j + 1]] > dict[top[j]]) // next element is greater than current element then swap
                    {
                        int temp = top[j];
                        top[j] = top[j + 1];
                        top[j + 1] = temp;
                    }
                    else if (dict[top[j + 1]] == dict[top[j]] && top[j] > top[j + 1]) //frequency is equal and current element if greater then next element
                    {
                        int temp = top[j];
                        top[j] = top[j + 1];
                        top[j + 1] = temp;
                    }
                    else
                        break;

                    j--;
                }

                for(int p=0;p<k && top[p]!=0;p++)
                {
                    Console.Write(top[p]+" ");
                }
            }
            Console.WriteLine();
        }

        void practise(int[] arr,int k)
        {
            int[] top = new int[k + 1];

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
                dict.Add(arr[i], 0);


            for(int i=0;i<arr.Length;i++)
            {
                if (!dict.ContainsKey(arr[i]))
                    dict.Add(arr[i], 1);
                else
                    dict[arr[i]]++;


                top[k] = arr[i];

                int j = k-1;

                while(j>=0)
                {
                    if(top[j+1]>top[j]) //This case is then top is like 0 0 0 0 5 and we want to convert it to 5 0 0 0 0
                    {
                        int temp = top[j + 1];
                        top[j+1] = top[j];
                        top[j]  = temp;
                    }

                    else if(dict[top[j]]==dict[top[j+1]] && top[j]>top[j+1]) //this case top is like 5 2 0 0 0 and we want to convert it to 2 5 0 0 0
                    {
                        int temp = top[j + 1];
                        top[j + 1] = top[j];
                        top[j] = temp;
                    }
                    j--;
                }

                for(int p=0;p<k;p++)
                {
                    if (top[p] != 0)
                        Console.Write(top[p]+" ");
                }
            }
           
        }
        // solution copied from geek for geeks
        void print_stream(int[] a,int k)
        {
            int n = a.Length; 
            // vector of size k+1 to store elements 
            int[] top = new int[k + 1];

            // array to keep track of frequency 
            Dictionary<int,
                       int> freq = new Dictionary<int,
                                                  int>();
            for (int i = 0; i < k + 1; i++)
                freq.Add(i, 0);

            // iterate till the end of stream 
            for (int m = 0; m < n; m++)
            {
                // increase the frequency 
                if (freq.ContainsKey(a[m]))
                    freq[a[m]]++;
                else
                    freq.Add(a[m], 1);

                // store that element in top vector 
                top[k] = a[m];

                // search in top vector for same element  
                int i = find(top, a[m]);
                i--;

                // iterate from the position of element to zero 
                while (i >= 0)
                {
                    // compare the frequency and swap if higher  
                    // frequency element is stored next to it 
                    if (freq[top[i]] < freq[top[i + 1]])
                    {
                        int temp = top[i];
                        top[i] = top[i + 1];
                        top[i + 1] = temp;
                    }

                    // if frequency is same compare the elements  
                    // and swap if next element is high 
                    else if (freq[top[i]] == freq[top[i + 1]] &&
                                                  top[i] > top[i + 1])
                    {
                        int temp = top[i];
                        top[i] = top[i + 1];
                        top[i + 1] = temp;
                    }
                    else
                        break;

                    i--;
                }

                // print top k elements  
                for (int j = 0; j < k && top[j] != 0; ++j)
                    Console.Write(top[j] + " ");
            }
            Console.WriteLine();
        }

        int find(int[] arr, int ele)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == ele)
                    return i;
            return -1;
        }
    }
}
