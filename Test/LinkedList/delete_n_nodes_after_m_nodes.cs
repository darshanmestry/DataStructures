using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    class delete_n_nodes_after_m_nodes
    {
        public delete_n_nodes_after_m_nodes()
        {
            int[] arr1 = { 7,6, 5,4, 3, 2,1 };
         
            create_linked_list obj1 = new create_linked_list(arr1);

            int m = 2, n = 2;
            del_n_nodes_after_m_nodes(obj1.head,n,m);
        }

        void del_n_nodes_after_m_nodes(Node head,int n,int m)
        {
            Node cur = head;
            Node temp;
            while(cur!=null)
            {
                int i = 1;
               
                while(i<m && cur!=null)
                {
                  
                    cur = cur.next;
                    i++;
                }

                if (cur == null || cur.next == null)
                    return; 

                temp = cur;
                i = 1;
                while(i<=n && temp!=null)
                {
                  

                    if(temp.next!=null)
                        temp = temp.next;

                   
                    i++;

                  
                }

                    cur.next = temp.next;
                    cur = temp.next;
                
              
            }
        }
    }
}
