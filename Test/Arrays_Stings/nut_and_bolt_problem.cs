using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{

    /*
     Given a set of n nuts of different sizes and n bolts of different sizes. There is a one-one mapping between nuts and bolts. Match nuts and bolts efficiently. 
        Constraint: Comparison of a nut to another nut or a bolt to another bolt is not allowed. It means nut can only be compared with bolt and bolt can only be compared with a nut to see which one is bigger/smaller.
        Examples: 

        Input : nuts[] = {'@', '#', '$', '%', '^', '&'}
                bolts[] = {'$', '%', '&', '^', '@', '#'}
        Output : Matched nuts and bolts are-
                $ % & ^ @ # 
                $ % & ^ @ #  
     */
    class nut_and_bolt_problem
    {
        public nut_and_bolt_problem()
        {
            char[] nuts = { '@', '#', '$', '%', '^', '&' };
            char[] bolts = { '$', '%', '&', '^', '@', '#' };

            nutBoltMatch(nuts, bolts);
        }

        void nutBoltMatch(char[] nuts,char[] bolts)
        {
            int len = nuts.Length;

            Dictionary<char, int> dict = new Dictionary<char, int>();

            //Push nuts to dict
            for (int i = 0; i < len; i++)
                dict.Add(nuts[i], i);

            // searching for nuts for each bolt in hash map

            for (int i = 0; i < len; i++)
            {
                if(dict.ContainsKey(bolts[i]))
                {
                    nuts[i] = bolts[i];
                }
            }

            Console.WriteLine("Matched Nut and bolts are.");
            print(nuts);
            print(bolts);
        }

        void print(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
