using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class interval
    {
        public int start;
        public int end;
        public interval(int start,int end)
        {
            this.start = start;
            this.end = end;
        }
    }
    class merge_overlapping_intervals
    {
        public merge_overlapping_intervals()
        {
            List<interval> lis = new List<interval>();
            lis.Add(new interval(6, 8));
            lis.Add(new interval(1, 9));
            lis.Add(new interval(2, 4));
            lis.Add(new interval(4, 7));

            mergrOverlap(lis);
        }

        void mergrOverlap(List<interval> lis)
        {

            //Step 1 is to sort the list based on the starting interval
            lis = lis.OrderBy(x => x.start).ToList();

           //we will start will by check if 0th element is over lapping with 1st element in the list
            int index = 0;

            // We will comapre 1st elemnt of list with is previus element( 0th element) for overlap
            // This can be done by checking if end of 0th element >start of 1st element then there is a overlap and merge
            // if not then increment index. i.e index will become 1 it means we will check if 1st element of list is overlapping with its next element
            for(int i=1;i<lis.Count;i++)
            {
                if(lis[index].end > lis[i].start)
                {
                    lis[index].start = Math.Min(lis[index].start, lis[i].start);
                    lis[index].end = Math.Max(lis[index].end, lis[i].end);
                }
                else
                {
                    index++;
                }
            }

            // Now arr[0..index-1] stores the merged Intervals
            Console.WriteLine("The Merged Intervals are: ");
            for (int i = 0; i <= index; i++)
            {
                Console.WriteLine ("[" + lis[i].start + ","
                                            + lis[i].end + "]");
            }
        }

    }
}
