using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class next_greater_element_in_array
    {
        /*
         *  [4, 5, 2, 25},
                 * Element       NGE
           4      -->   5
           5      -->   25
           2      -->   25
           25     -->   -1
         */
        public next_greater_element_in_array()
        {
            int[] arr = { 4, 5, 2, 25 };
            // print_next_greater_element(arr);
            practise(arr);

            int[] arr2= { 11, 13, 21, 3 };
            practise(arr2);
        }

        void print_next_greater_element(int[] arr)
        {

            if (arr.Length == 1)
                Console.WriteLine(-1);

            Stack<int> st = new Stack<int>();

            if(arr.Length>0)
            st.Push(arr[0]);

            for(int i=1;i<arr.Length;i++)
            {
                while( st.Count>0 && arr[i]>st.Peek() )
                {
                    Console.WriteLine(st.Peek()+"-->"+arr[i]);
                    st.Pop();
                   

                }
              
                st.Push(arr[i]);
                
            }

            while(st.Count>0)
            {
                Console.WriteLine(st.Peek() + "--> -1");
                st.Pop();
            }
        }
   
        void practise(int[] arr)
        {
            Stack<int> st = new Stack<int>();

            if (arr.Length == 1)
                Console.WriteLine("Next element of " + arr[0] + " is -1");


            st.Push(arr[0]);

            for(int i=1;i<arr.Length;i++)
            {
                while (st.Count>0 && arr[i] > st.Peek())
                {
                    Console.WriteLine("Next element of " +st.Pop() + " is "+arr[i]);
                }

                st.Push(arr[i]);
            }

            while (st.Count > 0)
            {
                Console.WriteLine("Next element of " + st.Pop() + " is -1 ");
            }
        }
    }
}
