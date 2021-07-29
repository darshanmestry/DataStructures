using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class length_of_longest_valid_substring
    {
        /*
         Given a string consisting of opening and closing parenthesis, find the length of the longest valid parenthesis substring.

        Examples: 

        Input : ((()
        Output : 2
        Explanation : ()

        Input: )()())
        Output : 4
        Explanation: ()() 

        Input:  ()(()))))
        Output: 6
        Explanation:  ()(())
         */
        public length_of_longest_valid_substring()
        {
            Console.WriteLine(solution("((()")); //2
            Console.WriteLine(solution(")()())"));//4
            Console.WriteLine(solution("()(()))))"));//6
          
        }

        int solution(string str)
        {
            if (str.Length == 0)
                return -1;
            int cnt = 0;
            Stack<char> st = new Stack<char>();

            for(int i=0;i<str.Length;i++)
            {
                if (str[i] == '(')
                    st.Push(str[i]);
                else
                {
                    if( st.Count>0 && st.Peek()=='(')
                    {
                        st.Pop();
                        cnt+=2;
                    }
                }
            }
            return cnt;
        }

    }
}
