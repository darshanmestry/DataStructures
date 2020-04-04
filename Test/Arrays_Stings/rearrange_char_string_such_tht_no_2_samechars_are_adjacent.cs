using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class rearrange_char_string_such_tht_no_2_samechars_are_adjacent
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();
        char[] maxheap;
        public rearrange_char_string_such_tht_no_2_samechars_are_adjacent()
        {
            /*
             * Given a string with repeated characters, the task is to rearrange characters in a string so that no two adjacent characters are same.

            Note : It may be assumed that the string has only lowercase English alphabets.

            Examples:
             * Input: aaabc 
            Output: abaca 

            Input: aaabb
            Output: ababa 

            Input: aa 
            Output: Not Possible

            Input: aaaabc 
            Output: Not Possible
             */

            //string str = "bcaaa";

            //string str = "aa";

            //string str = "aaabb";

            string str = "aaaabc";
            for (int i=0;i<str.Length;i++)
            {
                if (!freq.ContainsKey(str[i]))
                    freq.Add(str[i], 1);
                else
                    freq[str[i]]++;
            }

            maxheap = new char[freq.Count];

            int j = 0;
            foreach(KeyValuePair<char,int> pair in freq)
            {
                maxheap[j] = pair.Key;
                j++;
            }

            buildHeap();


            rearrange();
        }

        void rearrange()
        {
            string str = "";
            int i = 0;
            int j = 0;
            char prev='#';
            while (freq.Count > 0)
            {
               
                char ch = maxheap[j];

                if(prev==ch)
                {
                    Console.WriteLine("Not possible");
                    break;
                }
                freq[maxheap[j]]--;
                str+= ch;
                
                int leftchild = (2 * j) + 1;
                int rightchild = (2 * j) + 2;

                int element_to_consider = ((leftchild < maxheap.Length && freq.ContainsKey(maxheap[leftchild])&& freq[maxheap[leftchild]]>0)) ? leftchild : -1;

                if(element_to_consider==-1)
                 element_to_consider= ((rightchild < maxheap.Length && freq.ContainsKey(maxheap[rightchild]) && freq[maxheap[rightchild]] > 0)) ? rightchild : -1;

                if (freq[maxheap[j]] == 0)
                {
                    freq.Remove(maxheap[j]);
                    j++;
                }


                if (element_to_consider != -1)
                {
                    char next = maxheap[element_to_consider];

                    if (ch == next)
                    {
                        Console.WriteLine("Not possible");
                        break;
                    }
                    freq[next]--;
                    str += next;

                    if (freq[maxheap[element_to_consider]] == 0)
                        freq.Remove(maxheap[element_to_consider]);

                    prev = next;
                }
                else
                    prev = ch;

            }
        }

        void buildHeap()
        {
            for(int i=0;i<=(maxheap.Length-1)/2;i++)
            {
                maxheapify(maxheap[i], i);
            }
        }

        void maxheapify(char c,int index)
        {
            int maxindex = index;

            int leftchild =( 2 * index )+ 1;
            int rightchild = (2 * index) + 2;

            if( leftchild <maxheap.Length && freq[maxheap[leftchild]]> freq[c])
            {
                maxindex = leftchild;
            }

            if(rightchild <maxheap.Length && freq[maxheap[rightchild]] > freq[c])
            {
                maxindex = rightchild;
            }

            if(maxindex!=index)
            {
                char temp = maxheap[maxindex];
                maxheap[maxindex] = maxheap[index];
                maxheap[index] = temp;

                maxheapify(maxheap[maxindex], maxindex);
            }
        }
    }
}
