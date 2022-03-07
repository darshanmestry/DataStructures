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


            //int res = maxPartition("aabccdac");

            BFS_on_graph obj = new BFS_on_graph();

            int[] arr = { 10, 20, 7 };
            int k = 4;




           
            //int res=minSum(arr, arr.Length,k);
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


            //int[] c1 = { 4, 2, 2, 4, 2 };

            //int[] c2 = { 1, 2, 3, 2 };

            //int[] c3 = { 0, 5, 4, 4, 5, 12 };
            ////int res = SmartNews_Code2(c3);


            //int[] a1 = { 0, 3, 3, 7, 5, 3, 11, 1 };
            //int res = SmartNews_code1(a1);


            //int[] a2 = { 1, 4, 7, 3, 3, 5 };
            ////int res = SmartNews_code1(a2);

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


        //smart news code 2
        static int SmartNews_Code2(int[] A)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            int start_index = 0;
            int end_index = 0;

            int cnt = 0;

            int ans = int.MinValue;
            while(end_index<A.Length)
            {
                if (!dict.ContainsKey(A[end_index]))
                {
                    dict.Add(A[end_index], 1);
                    cnt++;
                }
                else
                    dict[A[end_index]]++;

                while(cnt>2)
                {
                    dict[A[start_index]]--;

                    start_index++;

                    if(dict[A[start_index]]==0)
                     cnt--;

                }


                int temp = end_index - start_index + 1;
                ans = Math.Max(temp, ans);

                end_index++;
            }
            return ans;
        }



        //smart news code 1
        static int SmartNews_code1(int[] A)
        {
            List<int> lis = new List<int>();
            HashSet<int> ht = new HashSet<int>();
            int ans = int.MinValue;
            for (int i = 0; i < A.Length; i++)
            {
                if (!ht.Contains(A[i]))
                    ht.Add(A[i]);
            }


            Dictionary<char, int> dict = new Dictionary<char, int>();


            for (int i = 0; i < A.Length-1; i++)
            {
                for (int j = i+1; j < A.Length; j++)
                {

                    if (A[i] == A[j])
                        continue;

                    bool isBreak = false;
                    int temp_start = A[i] < A[j] ? A[i] : A[j];
                    int temp_end =   A[j] > A[i] ? A[j] : A[i];

                    temp_start++;

                    while (temp_start < temp_end)
                    {
                        if (ht.Contains(temp_start))
                        {
                            isBreak = true;
                            break;
                        }
                        temp_start++;
                    }

                    if (isBreak)
                        continue;
                    
                     int temp_ans = Math.Abs(i - j);

                     ans = Math.Max(temp_ans, ans);
                    

                }
            }

            return ans;
        }


        // Function to obtain the minimum possible
        // sum from the array by K reductions
        static int minSum(int[] a, int n, int k)
        {

            // Implements the MaxHeap
            List<int> q = new List<int>();
            for (int i = 0; i < n; i++)
            {

                // Insert elements into the MaxHeap
                q.Add(a[i]);
            }

            q.Sort();
            while (q.Count != 0 && k > 0)
            {
                double top =  q[q.Count - 1] / 2;

                // Remove the maximum
                // Insert maximum / 2

                int d=(int)Math.Ceiling(top);
                q[q.Count - 1] = d;

                k--;
                q.Sort();
            }

            // Stores the sum of remaining elements
            int sum = 0;
            while (q.Count != 0)
            {
                sum += q[0];
                q.RemoveAt(0);
            }
            return sum;
        }



        static int maxPartition(string s)
        {
            // P will store the answer
            int n = s.Length, P = 0;

            // Current will store current string
            // Previous will store the previous
            // string that has been taken already
            string current = "", previous = "";

            for (int i = 0; i < n; i++)
            {

                // Add a character to current string
                current += s[i];

                if (!current.Equals(previous))
                {

                    // Here we will create a partition and
                    // update the previous string with
                    // current string
                    previous = current;

                    // Now we will clear the current string
                    current = "";

                    // Increment the count of partition.
                    P++;
                }
            }
            return P;
        }
        static void Facebook_amsterdam_question_1()
        {
            /*
             *  Solve a mathematics expression using only * and + operators no parenthesis. For example:
                    String input = "42+10*2+4*3+4";
                    output: 78
             */

            string s = "42+10*2*4*3+4";

            if (string.IsNullOrEmpty(s))
                return;

            List<string> lis = s.Split('+').ToList();
            int res = 0;
            foreach(string str in lis)
            {
                int curNo = 0;
                int lastNo = 1;
                int i = 0;
                while(i<str.Length)
                {
                    if (str[i] != '*')
                    {
                        curNo = curNo * 10 + (str[i] - '0');
                    }
                    else
                    {
                        lastNo = lastNo * curNo;
                        curNo = 0;
                    }
                    i++;
                }

                if (lastNo != 1)
                 res = res + (lastNo*curNo);
                
                else
                  res += curNo;

            }
            Console.WriteLine(res);
        }


        static void phonepe()
        {
            List<string> list = new List<string>();

            list.Add("1,2:3,-1");
            list.Add("2,4:4,1");
            list.Add("3,,1");
            list.Add("4,,2");
            list.Add("5,6,2");


            Dictionary<string, string> dict = new Dictionary<string, string>();

            foreach(string str in list)
            {
                string[] temp = str.Split(',');
                string id = temp[0];

            }

        }
    }
}