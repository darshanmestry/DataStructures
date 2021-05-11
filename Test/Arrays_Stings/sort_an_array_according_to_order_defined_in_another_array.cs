using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class sort_an_array_according_to_order_defined_in_another_array
    {
        /*
         Given two arrays A1[] and A2[], sort A1 in such a way that the relative order among the elements will be 
        same as those are in A2. For the elements not present in A2, append them at last in sorted order. 
        Example: 

        Input: A1[] = {2, 1, 2, 5, 7, 1, 9, 3, 6, 8, 8}
               A2[] = {2, 1, 8, 3}
        Output: A1[] = {2, 2, 1, 1, 8, 8, 3, 5, 6, 7, 9}
        The code should handle all cases like the number of elements in A2[] may be more or less compared to A1[]. 
                A2[] may have some elements which may not be there in A1[] and vice versa is also possible.
         */
        public sort_an_array_according_to_order_defined_in_another_array()
        {
            int[] a1 = { 2, 1, 2, 5, 7, 1, 9, 3, 6, 8, 8 };
            int[] a2 = { 2, 1, 8, 3 };

            int[] res = sort_array(a1, a2);
        }

        int[] sort_array(int[] a1,int[] a2)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            //int[] temp = new int[a1.Length];


            // Store freq cont of each element of A1
            for(int i=0;i<a1.Length;i++)
            {
                if (!dict.ContainsKey(a1[i]))
                    dict.Add(a1[i], 1);
                else
                    dict[a1[i]]++;
            }


            //iterate A2 and check for it in Dict if present then fill temp array with A2[i] i.e if a2[0] is occuring 2 times in a1[] then temp[] array will have a2[0] 2 times
           // Once the count is freq 0 remove the key
            int index = 0;
            for(int i=0;i<a2.Length;i++)
            {
                if(dict.ContainsKey(a2[i]))
                {
                    while(dict[a2[i]]>0)
                    {
                        a1[index] = a2[i];
                        dict[a2[i]]--;
                        index++;
                    }

                    if (dict[a2[i]] == 0)
                        dict.Remove(a2[i]);
                }
            }


            //Sort the Remaining elements in list and then add it to the a1[] one by one
            dict = dict.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach(KeyValuePair<int,int> pair in dict)
            {
                a1[index] = pair.Key;
                index++;
            }
            return a1;
        }
    }
}
