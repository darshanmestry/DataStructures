using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class celibrity_problem
    {
        /*
         * In a party of N people, only one person is known to everyone. Such a person may be present in the party, 
         * if yes, (s)he doesn’t know anyone in the party. 
         * We can only ask questions like “does A know B? “. Find the stranger (celebrity) in minimum number of questions.
         */

        int[,] arr={{0, 0, 1, 0},
                        {0, 0, 1, 0},
                        {0, 0, 0, 0},
                        {0, 0, 1, 0}};
        public celibrity_problem()
        {
            int n = 4;
            find_celibrity(n);

        }

        void find_celibrity(int n)
        {
            Stack<int> st = new Stack<int>();

            for(int i=0;i<n;i++)
            {
                st.Push(i);
            }

           

            while(st.Count>1)
            {
                int a = st.Peek();
                st.Pop();

                int b = st.Peek();
                st.Pop();

                if (knows(a,b))
                {
                    st.Push(b);
                }
                else
                {
                    st.Push(a);
                }
            }

            int c = st.Peek();
            st.Pop();

            for(int i=0;i<n;i++)
            {
                if(i!=c && ( knows(c,i) || knows(i,c)))
                {
                    Console.WriteLine("No celibrity present");
                    return;
                }
            }

            Console.WriteLine("Celibrity is " + c);



        }

        bool knows(int a ,int b)
        {
            return arr[a, b] == 1 ? true : false; 
        }
    }
}
