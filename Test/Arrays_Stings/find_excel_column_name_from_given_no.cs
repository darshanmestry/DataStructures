using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class find_excel_column_name_from_given_no
    {
        /*
         * MS Excel columns has a pattern like A, B, C, … ,Z, AA, AB, AC,…. ,AZ, BA, BB, … ZZ, AAA, AAB ….. etc. In other words, column 1 is named as “A”, column 2 as “B”, column 27 as “AA”.
            Given a column number, find its corresponding Excel column name. Following are more examples.

            Input          Output
             26             Z
             51             AY
             52             AZ
             80             CB
             676            YZ
             702            ZZ
             705            AAC
         */

        public find_excel_column_name_from_given_no()
        {
            int a=0;

            char n = (char)(a + 'A');

            findExcelColName(2);
            findExcelColName(26);
            findExcelColName(51);
            findExcelColName(52);
            findExcelColName(80);
            findExcelColName(676);
            findExcelColName(702);
            findExcelColName(705);

        }

        void findExcelColName(int n)
        {
            string str = "";
            while(n>0)
            {
                int rem = n % 26;

                if (rem == 0)
                {
                    str += 'Z'.ToString();
                    n = (n / 26)-1; // need to do -1 as index is from 0 to 25 
                }
                else
                {
                    // adding 'A' to rem will return the actual aplhabet. E.g. rem=2 then (rem-1)+'A' will give B
                    str += ((char)((rem-1) + 'A')).ToString(); // need to do -1 as index is from 0 to 25  
                    n = n / 26;
                }
                
            }

            Console.WriteLine(str);
        }
    }
}
