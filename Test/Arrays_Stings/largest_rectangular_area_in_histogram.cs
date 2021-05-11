using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class largest_rectangular_area_in_histogram
    {
        public largest_rectangular_area_in_histogram()
        {
            int[] hist = new int[] { 6, 2, 5, 4, 5, 1, 6 };
            //ans is 12

            //int[] hist = new int[] { 1,2,2,1};
            int area = pract(hist);
            largest_rect_Area(hist);
        }

        void largest_rect_Area(int[] arr)
        {

            /*
             * Note: We are pushing indexes on the stack not values of array
                1. Add to the stack if current value >=staack.top
                2. 
                    2.1. If Current value < stack.top then Keep remvoing from the stack till stack.top becomes empty or stack.top < current value
                    2.2. Use following formla to count area;
                        
                            int index=stack.pop()
                          area= arr[index]*(i-stack.top()-1)

             */
            int i = 0;

            Stack<int> st = new Stack<int>();
            int max_area = int.MinValue;
            while(i<arr.Length)
            {
                if(st.Count==0 ||arr[i]>=arr[st.Peek()])
                {
                    st.Push(i++);
                }
                else
                {
                    int index = st.Pop();

                    int area = arr[index] * (st.Count == 0 ? i : i - st.Peek() - 1);

                    max_area = Math.Max(area, max_area);
                }
                
            }


            while(st.Count>0)
            {
                int index = st.Pop();

                int area = arr[index] * (st.Count==0?i:i - st.Peek() - 1);

                max_area = Math.Max(area, max_area);
            }

        }
   
    
        int pract(int[] arr)
        {
            Stack<int> st = new Stack<int>();
            int maxrea = -1;
            int i = 0;
            while(i<arr.Length)
            {
                if(st.Count==0 || arr[i]>=arr[st.Peek()])
                {
                    st.Push(i);
                    i++;
                }
                else
                {
                    int index = st.Pop();
                    int area = arr[index] * (st.Count==0?i:i - st.Peek() - 1);
                    maxrea = Math.Max(area, maxrea);

                }
            }

            while(st.Count>0)
            {
                int index = st.Pop();
                int area = arr[index] * (st.Count==0?i:i - st.Peek() - 1);
                maxrea = Math.Max(area, maxrea);
            }

            return maxrea;
        }
    }
}
