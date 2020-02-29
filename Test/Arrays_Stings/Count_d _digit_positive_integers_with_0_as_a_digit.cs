using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class Count_d__digit_positive_integers_with_0_as_a_digit
    {
        
        public Count_d__digit_positive_integers_with_0_as_a_digit()
        {

        }

        double count(int d)
        {
            return 9*(Math.Pow(10,d-1) -Math.Pow(9,d-1));
        }
    }

}

/*
         *  Input : d = 1
            Output : 0
            There's no natural number of 1 digit that
            contains a zero.

            Input : d = 2
            Output : 9
            The numbers are, 10, 20, 30, 40, 50, 60, 
                             70, 80 and 90.

            Approach
            We can place any of {1, 2, ... 9} in D1
            Hence D1 can be filled in 9 ways.

            Apart from D1 all the other places can be  10 ways. 
            (we can place 0 as well)
            Hence the total numbers having d digits can be given as: 
            Total =  9*10d-1

            Now, let's find the numbers having d digits, that
            don't contain zero at any place. 
            In this case, all the places can be filled in 9 ways.
            Hence count of such numbers is given by:
            Non_Zero = 9d

            (9*10d-1 -9d)
            9(10,d-1  9,d-1)

            Now the count of numbers having at least one zero 
            can be obtained by subtracting Non_Zero from Total.
            Hence Answer would be given by:
            9*(10d-1 - 9d-1 ) 
         */
