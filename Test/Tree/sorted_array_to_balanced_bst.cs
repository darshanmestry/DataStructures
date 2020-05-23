using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tree
{
    class sorted_array_to_balanced_bst
    {
        public sorted_array_to_balanced_bst()
        {
            int[] arr = { 1, 2, 3, 4 };

            Node root = create_bst(arr,0,arr.Length-1);
        }

        Node create_bst(int[] arr, int start, int end)
        {

            if (start > end)
                return null;

            int mid = (start + end) / 2;

            Node newnode = new Node(arr[mid]);

            if (start == end)
                return newnode;

            newnode.left = create_bst(arr, start, mid - 1);
            newnode.right = create_bst(arr, mid + 1, end);

            return newnode;

    }
    }

   
}
