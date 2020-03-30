using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    /*
     * Find Next Sparse Number
        A number is Sparse if there are no two adjacent 1s in its binary representation. For example 5 (binary representation: 101) is sparse, but 6 (binary representation: 110) is not sparse.
        Given a number x, find the smallest Sparse number which greater than or equal to x.

        Examples:

        Input: x = 6
        Output: Next Sparse Number is 8

        Input: x = 4
        Output: Next Sparse Number is 4
     */
    class find_sparse_no
    {
        public find_sparse_no()
        {
            find_sparse(7);
        }

        void find_sparse(int no)
        {
            List<int> binary = new List<int>();
            int last_final = 0;
            while(no!=0)
            {
                binary.Add(no & 1);
                no = no >> 1;
            }

            binary.Add(0);

            for(int i=1;i<binary.Count-1;i++)
            {
                if(binary[i]==1 &&  binary[i-1]==1 && binary[i+1]!=1)
                {
                    binary[i + 1] = 1;
                    for (int j = i; j >= last_final; j--)
                        binary[j] = 0;

                    last_final = i + 1;
                }
            }

            int ans = 0;

            for(int i=0;i<binary.Count;i++)
            {
                ans += binary[i] * (1 << i);

            }

            Console.WriteLine(ans);
        }
    }
}
