using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class arrange_given_numbers_to_form_biggest_number
    {
        /*
         Given an array of numbers, arrange them in a way that yields the largest value. 
        For example, if the given numbers are {54, 546, 548, 60}, the arrangement 6054854654 gives the largest value.
        And if the given numbers are {1, 34, 3, 98, 9, 76, 45, 4}, then the arrangement 998764543431 gives the largest value.
         */
        public arrange_given_numbers_to_form_biggest_number()
        {
            int[] arr = { 54, 546, 548, 60 };
            string res = Biggest_Number(arr.ToList());
        }

        string Biggest_Number(List<int> list)
        {
            //List<string> Lis_str = list.ConvertAll<string>(x => x.ToString());

            list = list.OrderByDescending(x => x).ToList();
            string outputList = "";

            for(int i=0;i<list.Count;i++)
            {
                outputList = CompareNumber(outputList, list[i].ToString());
            }
            return outputList;
        }

        string CompareNumber(string X,string Y)
        {

            string op1 =X + Y;

            string op2 = Y + X;

            return op1.CompareTo(op2)>0 ? op1 : op2;
        }


    }
}
