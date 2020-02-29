using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    /*
     *  Build Lowest Number by Removing n digits from a given number
        Given a string ‘str’ of digits and an integer ‘n’, build the lowest possible number by removing ‘n’ digits 
        from the string and not changing the order of input digits.
        Examples:

        Input: str = "4325043", n = 3
        remove 5,4,3
        2043
        Output: "2043"

        Input: str = "765028321", n = 5

         remove  8,7,6,5,3
           0221
        Output: "0221"
     */
    class build_lowest_no_by_removing_n_digits
    {


        static string res = "";
        //static int minindex = 0;
       
        public build_lowest_no_by_removing_n_digits()
        {

            buildno("765028321", 5);
            
        }

        void buildno(string str,int n)
        {

            //int minindex = 0;



            //if (str.Length < n)
            //    return;

            //if (n == 0)
            //    res += str;

            //for(int i=1;i<str.Length;i++)
            //{
            //    if (str[i] < str[minindex] )
            //    {

            //        minindex = i;

            //    }
            //}

            //string newstr = str.Substring(minindex+1);
            //res += str[minindex];


            //buildno(newstr, n - minindex);

            // If there are 0 characters to remove from str,  
            // append everything to result  
            if (n == 0)
            {
                res += str;
                return;
            }

            int len = str.Length;

            // If there are more characters to  
            // remove than string length,  
            // then append nothing to result  
            if (len <= n)
                return;

            // Find the smallest character among  
            // first (n+1) characters of str.  
            int minIndex = 0;
            for (int i = 1; i <= n; i++)
                if (str[i] < str[minIndex])
                    minIndex = i;

            // Append the smallest character to result  
            res += str[minIndex];

            // substring starting from  
            // minIndex+1 to str.length() - 1.  
            String new_str = str.Substring(minIndex + 1);

            // Recur for the above substring  
            // and n equals to n-minIndex  
            buildno(new_str, n - minIndex);
        }

    }
}
