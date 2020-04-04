using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class queue_using_stacks
    {
        Stack<int> st = new Stack<int>();
        public queue_using_stacks()
        {
            Enqueue(1);
            Enqueue(2);
            Enqueue(3);
            Enqueue(4);

            Dequeue();
            Dequeue();
        }

        void Enqueue(int data)
        {
            Stack<int> temp = new Stack<int>();

            while(st.Count>0)
            {
                temp.Push(st.Peek());
                st.Pop();
            }

            st.Push(data);

            while(temp.Count>0)
            {
                st.Push(temp.Peek());
                temp.Pop();
            }

        }

        void Dequeue()
        {
            st.Pop();
        }
    }
}
