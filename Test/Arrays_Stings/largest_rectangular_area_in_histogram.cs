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

            largest_rect_Area(hist);
        }

        void largest_rect_Area(int[] arr)
        {
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
    }
}
