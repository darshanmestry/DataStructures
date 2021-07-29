using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_first_non_repeating_char_in_a_stream_of_chars
    {
        public find_first_non_repeating_char_in_a_stream_of_chars()
        {
            solution("geeksforgeeks");
        }

        //Approach
        /*
         * 
         * 1. If it is 1st occurence of char then store it in a list
         * 2. If it is 2nd occurent of char mark it as repated in bool[] isPresent and remove from the list
         * 3. With this approch List[0] will always contain 1st non repearing char
         */
        void solution(string str)
        {
            List<char> inDLL = new List<char>();
            bool[] isPresent = new bool[256];

            for(int i=0;i<str.Length;i++)
            {
                
                //if new char then only add in a list
                //Add first instance to list, for 2nd instance remove from the list
                if(!isPresent[str[i]])
                {
                    if (!inDLL.Contains(str[i]))
                    {
                        inDLL.Add(str[i]);
                    }
                    else
                    {
                        inDLL.Remove(str[i]);
                        isPresent[i] = true;
                    }
                }


                if (inDLL.Count > 0)
                    Console.WriteLine(str[i]+"  :"+inDLL.ElementAt(0));
            }
        }
    }
}
