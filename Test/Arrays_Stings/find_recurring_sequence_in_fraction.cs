using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_recurring_sequence_in_fraction
    {
        public find_recurring_sequence_in_fraction()
        {
            string res1 = findSeqence(8, 3);
            string res2 = findSeqence(50, 22);
            string res3 = findSeqence(11, 22);
        }


        string findSeqence(int numerator,int demoniator)
        {
            string res = "";

            Dictionary<int, int> dict = new Dictionary<int, int>();


            int rem = numerator % demoniator;

            while((rem!=0) && !dict.ContainsKey(rem))
            {
                //we are concered with key, value 1 is added just for the sake of adding
                dict.Add(rem, 1);

                
                rem = rem * 10;

                int fraction_part = rem / demoniator;

                res += fraction_part.ToString();

                rem = rem % demoniator;
            }

            if (rem == 0)
                return "";
            else
                return res;

        }
        //geeks for geeks
        string isSequencePresent(int numerator, int demominator)
        {
            // Initialize result
            string res = "";

            // Create a map to store already
            // seen remainders. Remainder is
            // used as key and its position in
            // result is stored as value.
            // Note that we need position for
            // cases like 1/6.  In this case,
            // the recurring sequence doesn't
            // start from first remainder.
            Dictionary<int, int> mp
                = new Dictionary<int, int>();

            // Find first remainder
            int rem = numerator % demominator;

            // Keep finding remainder until
            // either remainder becomes 0
            // or repeats
            while ((rem != 0) && (!mp.ContainsValue(rem)))
            {

                // Store this remainder
                mp[rem] = res.Length;

                // Multiply remainder with 10
                rem = rem * 10;

                // Append rem / denr to result
                int res_part = rem / demominator;
                res += res_part.ToString();

                // Update remainder
                rem = rem % demominator;
            }

            if (rem == 0)
                return "";
            else if (mp.ContainsKey(rem))
                return res.Substring(mp[rem]);

            return "";
        }
    }

  
    
}
