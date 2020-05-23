using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.LinkedList
{
    public class PolyNomialNode
    {
        public int coeff;
        public int pow;

        public PolyNomialNode next;
        public PolyNomialNode(int coeff,int pow)
        {
            this.coeff = coeff;
            this.pow = pow;
            next = null;
        }
    }

    class insert_polynomials
    {
        public PolyNomialNode head;

        public insert_polynomials(int[] coeffs,int[] pows)
        {
            for(int i = 0; i < coeffs.Length;i++)
            {
                insert_at_head(coeffs[i], pows[i]);
            }
        }

        void insert_at_head(int coeff,int pow)
        {
            if(head==null)
            {
                head = new PolyNomialNode(coeff, pow);
            }
            else
            {
                PolyNomialNode node = new PolyNomialNode(coeff, pow);
                node.next = head;
                head = node;
            }
        }

    }
    class add_2_polynomials_in_a_linkedlist
    {
        public add_2_polynomials_in_a_linkedlist()
        {
            /*
             * Given two polynomial numbers represented by a linked list. Write a function that add these lists means add the coefficients who have same variable powers.

                Example:

                Input:
                     1st number = 5x^2 + 4x^1 + 2x^0
                     2nd number = 5x^1 + 5x^0
                Output:
                        5x^2 + 9x^1 + 7x^0
                Input:
                     1st number = 5x^3 + 4x^2 + 2x^0
                     2nd number = 5x^1 + 5x^0
                Output:
                        5x^3 + 4x^2 + 5x^1 + 7x^0

             */

            int[] coeff1 = { 2,4,5};
            int[] pow1 = { 0, 1, 2 };

            insert_polynomials obj1 = new insert_polynomials(coeff1, pow1);

            int[] coeff2 = { 5, 5 };
            int[] pow2 = { 0, 1 };

            insert_polynomials obj2 = new insert_polynomials(coeff2, pow2);

            PolyNomialNode newnode = add_poly(obj1.head,obj2.head);

        }

        PolyNomialNode add_poly(PolyNomialNode head1,PolyNomialNode head2)
        {
            PolyNomialNode newList = new PolyNomialNode(0, 0);
            PolyNomialNode dummy = newList;

            PolyNomialNode cur1 = head1;
            int len1 = 0;
            while(cur1!=null)
            {
                cur1 = cur1.next;
                len1++;
            }

            PolyNomialNode cur2 = head2;
            int len2 = 0;
            while(cur2!=null)
            {
                cur2 = cur2.next;
                len2++;
            }

            cur1 = head1;
            cur2 = head2;

            if(len1>len2)
            {
                int cnt = len1 - len2;
                while(cnt>0)
                {
                    PolyNomialNode newnode = new PolyNomialNode(cur1.coeff, cur1.pow);

                    dummy.next = newnode;
                    dummy = dummy.next;
                    cur1 = cur1.next;
                    cnt--;
                }
            }

            if(len2>len1)
            {
                int cnt = len2 - len1;
                while (cnt > 0)
                {
                    PolyNomialNode newnode = new PolyNomialNode(cur2.coeff, cur2.pow);

                    dummy.next = newnode;
                    dummy = dummy.next;
                    cur2 = cur2.next;
                    cnt--;
                }
            }

            while(cur1!=null && cur2!=null)
            {
                int coeff = cur1.coeff + cur2.coeff;
                int pow = cur1.pow > cur2.pow ? cur1.pow : cur2.pow;

                PolyNomialNode newnode = new PolyNomialNode(coeff, pow);
                dummy.next = newnode;
                dummy = dummy.next;

                cur1 = cur1.next;
                cur2 = cur2.next;
            }
            return newList;
        }
    }
}
