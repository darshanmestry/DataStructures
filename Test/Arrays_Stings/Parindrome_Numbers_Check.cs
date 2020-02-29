using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class Parindrome_Numbers_Check
    {

        //2002 is palindrome
        public Parindrome_Numbers_Check()
        {

        }
        bool isPalindrome(int no)
        {

            int temp = 1;
            while(temp>=no)
            {
                temp = temp * 10;
            }


            //202
            int lastDigit = no % 10;
            //int firstDigit=//
            return true;
        }

    }
}
