using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class count_no_with_same_first_and_last_digit
    {
        /*
         Input  : start = 7,  end : 68
        Output : 9
        Number with same first and last digits are,
        7 8 9 11 22 33 44 55 66.

        Input  : start = 5,  end : 40
        Output : 8

        From 120 to 130, only 121 has same starting and ending digit
        From 440 to 450, only 444 has same starting and ending digit
        From 1050 to 1060, only 1051 has same starting and ending digit

        From above examples, we can observe that in each ten number span we have only one number which has the given property
        except 1 to 10 which has 9 numbers (all one digit number) 
        having same starting and ending digit.
        Using above property we can solve given problem, first we break the given interval into two parts that 
        is if interval is l to r, we break this into 1 to l and 1 to r, our answer is obtained by subtracting 
        result of first query from second query.
             */
        public count_no_with_same_first_and_last_digit()
        {
            int start = 37;
            int end = 68;

            int count = getCount(start, end);
        }

        int getCount(int start,int end)
        {
            int spans = end / 10;  //get total spans on end

            if (start < 10)        // if start is less than 10 then 10-start is no of elements we want
            {
                spans = spans + (10 - start);
                int firstDigit = GetFirstDigit(end);
                int lastDigit = end % 10;

                if (firstDigit > lastDigit)   // if first digit > last digit then we need to substract 1 from res
                    spans--;
            }
            else
            {

                spans = spans - (start / 10); // if both start and end are 2 or more digit nos

                int firstDigit = GetFirstDigit(start);
                int lastDigit = start % 10;

                if (lastDigit > firstDigit)
                    spans--;

            }


            
            //return helper(end) - helper(start - 1);

            return spans;
        }

        
        int GetFirstDigit(int x)
        {
            while (x >10)
                x = x / 10;

            return x;
        }
    
    
        
        int practise(int start,int end)
        {
            int span = end / 10;

            if(start<9)
            {
                span = span + (10 - start);

                int fdigit = GetFirstDigit(end);
                int ldigit = end % 10;

                if (fdigit > ldigit)
                    span--;

            }
            else
            {
                span = span - (start / 10);

                int fdigit = GetFirstDigit(start);
                int ldigit = start % 10;

                if (ldigit > fdigit)
                    span--;
            }

            return span;
        }
    }
}
