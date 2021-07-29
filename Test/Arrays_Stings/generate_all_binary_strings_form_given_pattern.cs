using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    /*
     Given a string containing of ‘0’, ‘1’ and ‘?’ wildcard characters, generate all binary strings that can be formed by replacing each wildcard character by ‘0’ or ‘1’.
        Example :

        Input str = "1??0?101"
        Output: 
                10000101
                10001101
                10100101
                10101101
                11000101
                11001101
                11100101
                11101101
     */
    class generate_all_binary_strings_form_given_pattern
    {
        public generate_all_binary_strings_form_given_pattern()
        {
            string str = "1??0?101";
            int cnt = wildCardWordCount(str);
            List<string> list = generateBinaryForm(cnt);
            print(list, str);
        }

        void print(List<string> binaryForm,string str)
        {
            for(int i=0;i<binaryForm.Count;i++)
            {
                string temp = binaryForm[i];
                int index = 0;
                for(int j=0;j< str.Length;j++)
                {
                    if(str[j]=='?')
                    {
                        Console.Write(temp[index]);
                        index++;
                    }
                    else
                    {
                        Console.Write(str[j]);
                    }
                }
                Console.WriteLine();
            }
        }
        
        List<string> generateBinaryForm(int wildCardWordCount)
        {
            List<string> list = new List<string>();

            int pow =(int) Math.Pow(2, wildCardWordCount);

            // add 0 seperately
            string addZero = "";
            for (int i = 0; i < wildCardWordCount; i++)
                addZero += "0";
            list.Add(addZero);

            // Add 1 to n-1 nos in list
            for(int i=1;i<pow;i++)
            {
                //string tempstr = "";
                string[] chArr = new string[wildCardWordCount];
                int startIndex = wildCardWordCount -1;
                int temp = i;
                while(temp!=0)
                {
                    if((temp & 1)==0)
                    {
                        chArr[startIndex] = "0";
                    }
                    else
                    {
                        chArr[startIndex] = "1";
                    }
                    startIndex--;
                    temp = temp >> 1;
                }

                // Add Trailing 0s. i.e if wildCardWordCount=3 then we will need 3digit binary but for 1 it will be 1(binary form) hence add 00 to start and make it 001
                while (startIndex >= 0)
                {
                    chArr[startIndex] = "0";
                    startIndex--;
                }

                //tempstr = trailingsZeros + tempstr;
                list.Add(string.Join("",chArr));

            }
            return list;
        }

        int wildCardWordCount(string str)
        {
            int cnt = 0;
            for(int i=0;i<str.Length;i++)
            {
                if (str[i] == '?')
                    cnt++;
            }
            return cnt;
        }
    }


}
