﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    /*
     * Input:  [10, 3, 5, 6, 20]
        Output: 1200
        Multiplication of 10, 6 and 20
 
        Input:  [-10, -3, -5, -6, -20]
        Output: -90

        Input:  [1, -4, 3, -6, 7, 0]   
        Output: 168
     * *
     */
    class max_product_triplet_subsequnce_of_size_3
    {
        public max_product_triplet_subsequnce_of_size_3()
        {
            int[] arr1 = { 10, 3, 5, 6, 20 };
            int[] arr2 = { -10, -3, -5, -6, -20 };
            int[] arr3 = { 1, -4, 3, -6, 7, 0 };

            findTriple(arr1);
            findTriple(arr2);
            findTriple(arr3);

            practise(arr1);
            practise(arr2);
            practise(arr3);

        }


        void findTriple(int[] arr)
        {

            int min1=int.MaxValue, min2=int.MaxValue;
            int max1=int.MinValue, max2= int.MinValue, max3= int.MinValue;

            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = arr[i];
                }
                else if (arr[i] > max2)
                {
                    max3 = max2;
                    max2 = arr[i];
                }

                else if (arr[i] > max3)
                    max3 = arr[i];

                if (arr[i] < min1)
                {
                    min2 = min1;
                    min1 = arr[i];
                }
                else if (arr[i] < min2)
                    min2 = arr[i];
            }

            int prod_possiility1 = max1 * max2 * max3;

            int prod_possiility2 = min1 * min2 * max1;

            Console.WriteLine(prod_possiility1 > prod_possiility2 ? prod_possiility1 : prod_possiility2);
        }
   
        void practise(int[] arr)
        {
            int first_max=int.MinValue, second_max=int.MinValue, thrid_max = int.MinValue;

            int first_min=int.MaxValue, second_min = int.MaxValue;

            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]>first_max) //while changing 1st max, 2nd max will become 1st max and 3rd max will become 2nd max
                {
                    thrid_max = second_max;
                    second_max = first_max;
                    first_max = arr[i];
                }
                else if(arr[i]>second_max)
                {
                    thrid_max = second_max;
                    second_max = arr[i];
                }
                else if(arr[i]>thrid_max)
                {
                    thrid_max = arr[i];
                }

                if (arr[i] < 0)
                {
                    if (arr[i] < first_min)
                    {
                        second_min = first_min;
                        first_min = arr[i];
                    }
                    else if (arr[i] < second_min)
                    {
                        second_min = arr[i];
                    }
                }
            }

            int res_possibily_1 = first_max * second_max * thrid_max;

            int res_poosibilty_2 = first_max * first_min * second_min;

            int final_res = Math.Max(res_possibily_1, res_poosibilty_2);

            Console.WriteLine(final_res);
        }
    }
}
