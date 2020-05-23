using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Stack
{
    class sort_stack_using_recursion
    {
        /*
         * Input:  -3  <--- Top
                14 
                18 
                -5 
                30 

        Output: 30  <--- Top
                18 
                14 
                -3 
                -5 
                 */
        Stack<int> st;
        public sort_stack_using_recursion()
        {
            st = new Stack<int>();
            st.Push(-3);
            st.Push(14);
            st.Push(18);
            st.Push(-5);
            st.Push(30);


            sortStack();
        }

        void sortStack()
        {
            if(st.Count>0)
            {
                int data = st.Peek();
                st.Pop();

                sortStack();

                sortedInsert(data);

            }
        }

        void sortedInsert(int data)
        {
            if (st.Count == 0 || data > st.Peek())
            {
                st.Push(data);
                return;
            }
            int temp = st.Peek();

            st.Pop();
            sortedInsert(data);

            st.Push(temp);
        }
    }
}
