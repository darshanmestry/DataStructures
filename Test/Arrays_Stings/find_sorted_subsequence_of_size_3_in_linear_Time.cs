﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_sorted_subsequence_of_size_3_in_linear_Time
    {
        /*
         * Input: arr[] = {12, 11, 10, 5, 6, 2, 30}
            Output: 5, 6, 30
            Explanation: As 5 < 6 < 30, and they 
            appear in the same sequence in the array 

        ALGORITHM
        Create an auxiliary array smaller[0..n-1]. smaller[i] stores the index of a number which is smaller than arr[i] and is on left side. 
        The array contains -1 if there is no such element.
Create another auxiliary array greater[0..n-1]. greater[i] stores the index of a number which is greater than arr[i] and is on right side of arr[i]. The array contains -1 if there is no such element.
Finally traverse both smaller[] and greater[] and find the index [i] for which both smaller[i] and greater[i] are not equal to -1.
         */

        public find_sorted_subsequence_of_size_3_in_linear_Time()
        {
            int[] arr = { 12, 11, 10, 5, 6, 2, 30 };
            int[] arr2 = { 4, 3, 2, 1 };
            //sorted_subsequnce(arr);
           
            Optimized_solution(arr);
        }

        void sorted_subsequnce(int[] arr)
        {
            int n = arr.Length;
            int[] smallest_on_left = new int[n];
            int[] largest_on_right = new int[n];

            //{ 12, 11, 10, 5, 6, 2, 30}
            smallest_on_left[0] = -1;
            int min = 0;
            for(int i=1;i<n;i++)
            {
                if ( arr[i]> arr[min]) // if prev element is smaller than cur element then store index of prev elemtn
                {
                    smallest_on_left[i] = min; 
                }
                else     //if current element is smaller then min element then make current elem as min
                {
                    min = i;
                    smallest_on_left[i] = -1;
                }
            }

            //{ 12, 11, 10, 5, 6, 2, 30}
            largest_on_right[n - 1] = -1;
            int max_index = n-1;
            for(int i=n-1;i>=0;i--)
            {
                if(arr[i]<arr[max_index]) // if next elenet is greater then make store its index
                {
                    largest_on_right[i] = max_index;
                }
                else     // if current elem is greater then next elem then make current elem greater
                {
                    max_index = i;
                    largest_on_right[i] = -1;
                }
            }

           
            for(int i=0;i<n;i++)
            {
                if(smallest_on_left[i]!=-1 && largest_on_right[i]!=-1)
                {
                    Console.WriteLine(arr[smallest_on_left[i]] + "," + arr[i] + "," + arr[largest_on_right[i]]);
                }
            }
        }
  
    
        void Optimized_solution(int[] arr)
        {
            if (arr.Length < 3)
                Console.WriteLine("No triplets found");


            int seq = 1;

            int temp_first_elem = arr[0];
            int first_elem = temp_first_elem; // used to store the 1st element of result 
            int second_elem = int.MinValue; //used to store 2nd element of result

            for(int i=1;i<arr.Length;i++)
            {

                if (arr[i] == temp_first_elem) //continue if curent element is equal to minimum no
                    continue;

                else if(arr[i]<temp_first_elem) //if current element is smaller then min then update min
                {
                    temp_first_elem = arr[i];
                    continue;
                }
                else if(arr[i]<second_elem) //this if block will only run when value of seq=2 ,in this we store 1st elem of result in store in and 2nd elem of res in max_seq
                {
                    second_elem = arr[i];
                    first_elem = temp_first_elem;
                }
                else if(arr[i]>second_elem)  //if current element is greater than max_seq then update max_seq with current elem
                {
                    seq++;

                    if(seq==3)
                    {
                        Console.WriteLine(first_elem + " " + second_elem + " " + arr[i]);
                        return;
                    }
                    second_elem = arr[i];
                    first_elem = temp_first_elem;
                }

            }

            Console.WriteLine("No triplets found");
        }

       
    }
}
