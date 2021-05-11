﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class max_sum_rectangle
    {
        public max_sum_rectangle()
        {
            //https://www.geeksforgeeks.org/maximum-sum-rectangle-in-a-2d-matrix-dp-27/
            int[,] arr = { { 1, 2, -1, -4, -20 },
                         { -8, -3, 4, 2, 1 },
                           { 3, 8, 10, 1, 3 },
                           { -4, -1, 1, 7, -6 } };

            //start(arr);
            maxSumRect(arr);

        }
        //Geeks for geeks
        void start(int[,] a)
        {
            int cols = a.GetLength(1);
            int rows = a.GetLength(0);
            int[] currentResult;
            int maxSum = int.MinValue;
            int left = 0;
            int top = 0;
            int right = 0;
            int bottom = 0;

            for (int leftCol = 0; leftCol < cols; leftCol++)
            {
                int[] tmp = new int[rows];

                for (int rightCol = leftCol; rightCol < cols;
                     rightCol++)
                {

                    for (int i = 0; i < rows; i++)
                    {
                        tmp[i] += a[i, rightCol];

                    }
                    currentResult = kadane_helper(tmp);
                    if (currentResult[0] > maxSum)
                    {
                        maxSum = currentResult[0];
                        left = leftCol;
                        top = currentResult[1];
                        right = rightCol;
                        bottom = currentResult[2];
                    }
                }
            }

            Console.Write("MaxSum: " + maxSum + ", range: [("
                          + left + ", " + top + ")(" + right
                          + ", " + bottom + ")]");
        }
        //Geeks for geeks
        public int[] kadane_helper(int[] a)
        {
            int[] result = new int[] { int.MinValue, 0, -1 };
            int currentSum = 0;
            int localStart = 0;

            for (int i = 0; i < a.Length; i++)
            {
                currentSum += a[i];
                if (currentSum < 0)
                {
                    currentSum = 0;
                    localStart = i + 1;
                }
                else if (currentSum > result[0])
                {
                    result[0] = currentSum;
                    result[1] = localStart;
                    result[2] = i;
                }
            }

            // all numbers in a are negative
            if (result[2] == -1)
            {
                result[0] = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > result[0])
                    {
                        result[0] = a[i];
                        result[1] = i;
                        result[2] = i;
                    }
                }
            }
            return result;
        }
    
        void maxSumRect(int[,] arr)
        {
            int rowLen = arr.GetLength(0);
            int colLen = arr.GetLength(1);
            int maxsum = int.MinValue;
            //start from 0th Col and get all the vals of 0th col to temp[] and apply kadanes Algo on temp[] do this till col len
            // In 1st Itr we will be adding all the values of 0th ,1st, 2nd .. nth-1 col to temp[] and apply kadanes algo
            // in 2nd itr we wll be adding values of 1st, 2nd .. nth-1 col to temp[] and apply kadanes algo
            // in nth-1 itr we wll be adding values of .. nth-1 col to temp[] and apply kadanes algo

            for(int col=0;col<colLen;col++)
            {
                //this is will store values of 0th,1st,2nd .. nth-1 cols
                int[] temp = new int[rowLen];
                for (int colItr = col; colItr < colLen; colItr++)
                {
                    for (int row = 0; row < rowLen; row++)
                    {
                        temp[row] += arr[row, colItr];
                    }

                    int cursum = kadanes_algo(temp);
                    if (cursum > maxsum)
                        maxsum = cursum;

                }

            }
        }
    
        int kadanes_algo(int[] arr)
        {
            int max_so_Far = int.MinValue;
            int max_till_here = 0;

            for(int i=0;i<arr.Length;i++)
            {
                max_till_here += arr[i];

                if (max_till_here < 0)
                    max_till_here = 0;

                if (max_till_here>max_so_Far)
                {
                    max_so_Far = max_till_here;
                }

              
            }
            return max_so_Far;
        }
    }
}
