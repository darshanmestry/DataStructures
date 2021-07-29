using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class allocate_min_no_of_pages
    {
        public allocate_min_no_of_pages()
        {
            //Number of pages in books
            int[] arr = { 12, 34, 67, 90 };
           
            int m = 2; // No. of students
            int res = solution(arr, m);
        }

        int solution(int[] arr,int m)
        {
            long sum = 0;
            int n = arr.Length;
            // return -1 if no. of books
            // is less than no. of students
            if (n < m)
                return -1;

            // Count total number of pages
            for (int i = 0; i < n; i++)
                sum += arr[i];

            // initialize start as 0 pages
            // and end as total pages
            int start = 0, end = (int)sum;
            int result = int.MaxValue;

            // traverse until start <= end
            while (start <= end)
            {
                // check if it is possible to
                // distribute books by using
                // mid as current minimum
                int mid = (start + end) / 2;
                if (isFeasibleHelper(arr, m, mid))
                {
                    // update result to current distribution
                    // as it's the best we have found till now.
                    result = mid;

                    // as we are finding minimum and
                    // books are sorted so reduce
                    // end = mid -1 that means
                    end = mid - 1;
                }

                else
                    // if not possible means pages
                    // should be increased so update
                    // start = mid + 1
                    start = mid + 1;
            }

            // at-last return
            // minimum no. of pages
            return result;
        }

        bool isFeasibleHelper(int[] arr,int m,int curr_min)
        {
            int n = arr.Length;
            int studentsRequired = 1;
            int curr_sum = 0;

            // iterate over all books
            for (int i = 0; i < n; i++)
            {
                // check if current number of
                // pages are greater than curr_min
                // that means we will get the
                // result after mid no. of pages
                if (arr[i] > curr_min)
                    return false;

                // count how many students
                // are required to distribute
                // curr_min pages
                if (curr_sum + arr[i] > curr_min)
                {
                    // increment student count
                    studentsRequired++;

                    // update curr_sum
                    curr_sum = arr[i];

                    // if students required becomes
                    // greater than given no. of
                    // students, return false
                    if (studentsRequired > m)
                        return false;
                }

                // else update curr_sum
                else
                    curr_sum += arr[i];
            }
            return true;
        }
    }
}
