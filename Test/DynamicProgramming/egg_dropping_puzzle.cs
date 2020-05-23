using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.DynamicProgramming
{
    class egg_dropping_puzzle
    {
        public egg_dropping_puzzle()
        {
            int no_of_floors = 10;
            int no_of_eggs = 2;

            egg_drop(no_of_floors, no_of_eggs);
        }

        void egg_drop(int no_of_floors,int no_of_eggs)
        {
            /*
             Formula for f(no_of_floors,no_of_eggs)= Min(Max(f(n-x,e),f(x-1,e-1)+1)
             */

            int[,] arr = new int[no_of_floors + 1, no_of_eggs + 1];

            for (int i = 0; i < 1; i++) 
                arr[i, i] = 0;

            for (int i = 1; i <= no_of_floors; i++)
                arr[i, 1] = i;

            for (int i = 1; i <= no_of_eggs; i++)
                arr[1, i] = 1;


            for(int i=2;i<=no_of_floors;i++)
            {
                for(int j=2;j<=no_of_eggs;j++)
                {
                    arr[i, j] = int.MaxValue;
                    for (int x = 1; x <i;x++)
                    {
                        arr[i, j] = Math.Min(arr[i, j], Math.Max(arr[i - x, j], arr[x - 1, j - 1])+1);
                    }
                }
            }

            int res = arr[no_of_floors , no_of_eggs ];
        }
    }
}
