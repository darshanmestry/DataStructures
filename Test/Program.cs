using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Arrays_Stings;
using Test.BackTracking;
using Test.DynamicProgramming;
using Test.Graph;
using Test.Greedy;
using Test.Heap;
using Test.LinkedList;
using Test.Stack;
using Test.Tree;


namespace Test
{
    class Program
    {
        
        static void Main(string[] args)
        {


            all_distinct_subsets_of_given_set obj = new all_distinct_subsets_of_given_set();
            //List<int> lis = new List<int>();
            //lis.Add(-2);
            //lis.Add(-1);
            //lis.Add(-2);
            //lis.Add(5);

            //int res=solution(lis,3,10);

            //List<int> lis1 = new List<int>();
            //lis1.Add(1);
            //lis1.Add(2);

            //int res1 = solution(lis1, 3, 4);

            Console.WriteLine("done");
            Console.ReadLine();
                
        }


        static int solution(List<int> consecutiveDifference,int lowerBound,int upperBound)
        {

            // Apporach is to try every value between LowerBound and UpperBound and calculte difference  of subraction between  [Every Val of Lb to Ub]- [consecutiveDifference[0..n-1]]
            // If differnce lies between the limits then we calculate next values otherwise we stop the calculation,
            //Along with it we also maintain TotolCnt which stores count of valid list,
            int totalCnt = 0;
            while(lowerBound<=upperBound)
            {
                int firstVal=lowerBound;
                bool isBreak = false;
                List<int> temp = new List<int>();

                for(int i=0;i<consecutiveDifference.Count;i++)
                {
                    int secondVal = consecutiveDifference.ElementAt(i);
                    int diff = firstVal - secondVal;

                    if(diff<lowerBound || diff>upperBound)
                    {
                        isBreak = true;
                        break;
                    }
                 
                    firstVal = diff;

                    temp.Add(diff);
                }

                for (int i = 1; i < consecutiveDifference.Count; i++)
                {
                    int fv = temp.ElementAt(i - 1) - temp.ElementAt(i);
                    int sv = consecutiveDifference.ElementAt(i - 1) - consecutiveDifference.ElementAt(i);


                    if (fv != sv)
                        isBreak = true;
                }


                if (!isBreak)
                    totalCnt++;

                lowerBound++;
            }
            return totalCnt;

        }

        

       



    }
}