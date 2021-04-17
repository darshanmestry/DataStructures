using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class count_of_n_digit_nos_whoes_sum_is_equal_to_given_sum
    {
        public count_of_n_digit_nos_whoes_sum_is_equal_to_given_sum()
        {
            count_n_digit(3, 6);

        }

        void count_n_digit(int n,int sum)
        {
            int end = (int)Math.Pow(10,n);
            int start = (int)Math.Pow(10, n - 1);
            int count = 0;
            for(int i=start;i<end;i++)
            {
                int temp_sum = 0;
                int temp = i;
                while(temp>0)
                {
                    temp_sum += (temp % 10);


                    temp = temp / 10;


                    if (temp_sum > sum)
                        break;
                }
                if (temp_sum == sum)
                {
                    i += 8; //increment by 9 but as for loop is used it will by default increment by  9 so increment by 8
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
