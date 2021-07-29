using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_amount_of_water_in_given_glass
    {
        public find_amount_of_water_in_given_glass()
        {
            /*
             * There are some glasses with equal capacity as 1 litre. The glasses are kept as follows:
                   1
                 2   3
              4    5    6
            7    8    9   10
            You can put water to only top glass. If you put more than 1 litre water to 1st glass, water overflows and fills equally in 
            both 2nd and 3rd glasses. Glass 5 will get water from both 2nd glass and 3rd glass and so on.
            If you have X litre of water and you put that water in top glass, how much water will be contained by jth glass in ith row?

            Example. If you will put 2 litre on top.
            1st – 1 litre
            2nd – 1/2 litre
            3rd – 1/2 litre

            Input is i(row now) and j( jth glass) x= total amount of water poured
             */

            int i = 2, j = 2, x = 2;
            findwater(i, j, x);
            float res=practise(i, j, x);
        }

        void findwater(int i,int j,float x)
        {
            if(j>i)
            {
                Console.WriteLine("Invalid input");
            }

            int totalglasses = (i * (i + 1));

            float[] glasses = new float[totalglasses+2];

            int index = 0;
            glasses[index] = x;

            for(int row=1;row<=i;row++)
            {
                // we are iterating coll till row as in 1st row there will be 1 col,in 2nd row there will be 2 cols, in 3rd row there will be 3 cols and so on..
                for(int col=1;col<=row;col++)
                {


                    x = glasses[index];

                    glasses[index] = x >= 1.0f ? 1.0f : x;

                    x = x >= 1.0f ? x - 1 : 0.0f;

                    glasses[index + row] += x / 2;
                    glasses[index + row + 1] += x / 2;

                    index++;
                }
            }

            // The index of jth glass in ith
            // row will be i*(i-1)/2 + j - 1
            float res = glasses[(int)(i * (i - 1) /2 + j - 1)];
       }
    
        float practise(int i,int j,int total_Water)
        {
            int total_glasses = (i * i + 1) / 2;

            float[] glasses = new float[total_glasses];


            //initially pull all the water in glass 1;
            int index = 0;
            glasses[index] = total_Water;

            //1st row will will have 1 col
            //2nd row will have 2 col
            //3rd row will have 3 col and so on..
            for(int row=1;row<i;row++)
            {
                for(int col=1;col<=row;col++)
                {
                    float water = glasses[index];

                    glasses[index] = water >= 1.0f ? 1.0f : water;


                    float remaining_Water = water >= 1.0f ? water - 1.0f : 0.0f;

                    glasses[index + row] = remaining_Water / 2;
                    glasses[index + row + 1] = remaining_Water / 2;

                    index++;
                }
            }
            //formula to get water_in_ith_row_jth_col (i * i - 1) / (2 + j - 1)
            float water_in_ith_row_jth_col = glasses[(i * i - 1) / (2 + j - 1)];
            return water_in_ith_row_jth_col;
        }
    }
}
