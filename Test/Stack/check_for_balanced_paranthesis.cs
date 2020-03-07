using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Stack
{

    //[()]{}{[()()]()}
    class check_for_balanced_paranthesis
    {
        public check_for_balanced_paranthesis()
        {
            string exp = "[()]{}{[()()]()}";
            checkParanthesis(exp);
        }

        void checkParanthesis(string exp)
        {
            Stack<char> st = new Stack<char>();

            for(int i=0;i<exp.Length;i++)
            {
                if(exp[i]=='{' || exp[i]=='(' || exp[i]=='[')
                {
                    st.Push(exp[i]);
                }
                else
                { 
                    if(exp[i]=='}')
                    {
                        if(st.Peek()=='{')
                        {
                            st.Pop();
                        }
                        else
                        {
                            Console.WriteLine("Not Balanced");
                            return;
                        }
                    }

                    if (exp[i] == ')')
                    {
                        if (st.Peek() == '(')
                        {
                            st.Pop();
                        }
                        else
                        {
                            Console.WriteLine("Not Balanced");
                            return;
                        }
                    }

                    if (exp[i] == ']')
                    {
                        if (st.Peek() == '[')
                        {
                            st.Pop();
                        }
                        else
                        {
                            Console.WriteLine("Not Balanced");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("Balanced");
        }
    }
}
