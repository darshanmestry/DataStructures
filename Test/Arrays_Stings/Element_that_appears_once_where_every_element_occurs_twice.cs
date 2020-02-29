using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    class Element_that_appears_once_where_every_element_occurs_twice
    {
        public Element_that_appears_once_where_every_element_occurs_twice()
        {

        }

        void findsingleelement(int[] arr)
        {
            int res = arr[0];

            for(int i=1;i<arr.Length;i++)
            {
                res = res ^ arr[i];
            }

            Console.WriteLine(res);
        }
    }
}
