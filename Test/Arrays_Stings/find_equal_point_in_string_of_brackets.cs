using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_equal_point_in_string_of_brackets
    {
        /*
         * Given a string of brackets, the task is to find an index k which decides the number of opening brackets is equal to the number of closing brackets.
            String must be consists of only opening and closing brackets i.e. ‘(‘ and ‘)’.

            An equal point is an index such that the number of opening brackets before it is equal to the number of closing brackets from and after.

            Examples:



            Input : str = "(())))("
            Output:   4
            After index 4, string splits into (())
            and ))(. Number of opening brackets in the 
            first part is equal to number of closing 
            brackets in the second part.

            Input : str = "))"
            Output: 2
         */

        public find_equal_point_in_string_of_brackets()
        {
            string str = "))(()))(";

            findIndex(str);

            string str2 = "))";
            findIndex(str2);
        }

        void findIndex(string str)
        {
            int end = -1;
            int start = -1;
            Stack<char> st = new Stack<char>();
            for(int i=0;i<str.Length;i++)
            {
                if (str[i] == '(')
                {
                    st.Push(str[i]);
                    if (start == -1)
                        start = i;
                }
                else
                {
                    if (st.Count > 0)
                    {
                        st.Pop();
                        end = i;
                    }

                }
            }

            Console.WriteLine(start+","+end);
        }
    }
}
