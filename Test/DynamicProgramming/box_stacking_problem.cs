using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    /*
     Given boxes of different dimensions, stack them on top of each other to get maximum height such that box on top has strictly less length and width than box under it.
         Algo
        1. First Find all the combinations of the box possible by shuffling it. (i.e. L chages to W,W changes to H,H changes to L and so on..)and store it.
        2. Then store the above combinations bases on the area of the box  i.e L x W
        3. Carry on Longest increasing subsequence Algo. on the same by checking the area of 2 boxes ans store the hegith in res[]
     */
    class box_stacking_problem
    {
        public box_stacking_problem()
        {
            List<box> boxList = new List<box>(); ;
            box b1 = new box(4, 6, 7);
            box b2 = new box(1, 2, 3);
            box b3 = new box(4, 5, 6);
            box b4 = new box(10, 12, 32);



            boxList.Add(b1);
            boxList.Add(b2);
            boxList.Add(b3);
            boxList.Add(b4);

            SolveBoxDP(boxList);

        }
        void SolveBoxDP(List<box> boxList)
        {

            List<box> AllRotationCombinations = getAllCombinationsOfBoxes(boxList);

            //Sort All boxes based on area
            AllRotationCombinations = AllRotationCombinations.OrderByDescending(x => x.area).ToList();

            print(AllRotationCombinations);
            //Implement Longest Increasing subsequence on AllRotationCombinations

            int[] res = new int[AllRotationCombinations.Count];

            //initially we will store individual heigts of the boxes in res[]
            for (int i = 0; i < AllRotationCombinations.Count; i++)
                res[i] = AllRotationCombinations[i].H;


            // We will try see if AllRotationCombinations[i] can be placed on top of AllRotationCombinations[j] and if yes then store its adding of height at res[i]
            for (int i=1;i<AllRotationCombinations.Count;i++) 
            {
               
                for (int j=0;j<i;j++)
                {
                    // Check if (L and W) of AllRotationCombinations[i] < AllRotationCombinations[j] then only we can place [i] box on top of [j]
                    //if(AllRotationCombinations[j].area> AllRotationCombinations[i].area)
                    if ((AllRotationCombinations[i].W < AllRotationCombinations[j].W) && (AllRotationCombinations[i].L < AllRotationCombinations[j].L))
                    {
                        int newHeight = res[j] + AllRotationCombinations[i].H;
                        res[i] = Math.Max (newHeight,res[i]);
                    }
                }
               
            }
        }

        List<box> getAllCombinationsOfBoxes(List<box> boxList)
        {
            //To generate all the rotations of the box we will need another list with size if boxList.Count * 3

            List<box> AllRotationCombinations = new List<box>();

            foreach (box obj in boxList)
            {
                // To generate Combination Take (L,W,H) as L,then Max of (W,H if L taken as 1st arg) and Min (W,H if L taken as 1st arg)
                box comb1 = new box( Math.Max(obj.W, obj.H), Math.Min(obj.W, obj.H), obj.L);
                //Calculate area
                comb1.area = comb1.L * comb1.W;

                box comb2 = new box(Math.Max(obj.L, obj.H), Math.Min(obj.L, obj.H), obj.W );
                //Calculate area
                comb2.area = comb2.L * comb2.W;

                box comb3 = new box(Math.Max(obj.W, obj.L), Math.Min(obj.W, obj.L), obj.H );

                //Calculate area
                comb3.area = comb3.L * comb3.W;

                AllRotationCombinations.Add(comb1);
                AllRotationCombinations.Add(comb2);
                AllRotationCombinations.Add(comb3);
            }
            return AllRotationCombinations;
        }

        void print(List<box> boxList)
        {
            foreach(box b in boxList)
            {
                Console.WriteLine(b.L + " " + b.W + " " + b.H);
            }
        }
    }


    class box
    {
        public int L;
        public int W;
        public int H;
        public int area;
         public box(int L,int W,int H)
         {
            this.L = L;
            this.W = W;
            this.H = H;
        }
    }
}
