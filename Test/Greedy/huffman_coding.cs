using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Greedy
{

  
    class huffman
    {
        public int data;
        public char c;


        public huffman left;
        public huffman right;
      
        public huffman(int data,char c)
        {
            this.data = data;

            this.c = c;
            left = null;
            right = null;
        }
    }

    class minheap
    {
        public int size;
        public huffman[] arr;
        public minheap(huffman[] arr, int size)
        {
            this.arr = arr;
            this.size = size;
            buildheap();
        }


        void buildheap()
        {
            for (int i = (size - 1) / 2; i >= 0; i--)
            {
                minHeapify(arr, i);
            }
        }


        public void insert(int data,char c)
        {

            size++;

            int i = size - 1;
            arr[i] = new huffman(data,'-');

            while (i != 0 && arr[getParent(i)].data > arr[i].data)
            {
                huffman temp = arr[getParent(i)];
                arr[getParent(i)] = arr[i];
                arr[i] = temp;

                i = getParent(i);
            }
        }


        public huffman extractMin()
        {
            huffman min = arr[0];

            delete(0);
            return min;

        }
        void delete(int index)
        {
            arr[index] = arr[size - 1];

            //arr[size - 1] = null;
            size--;

            minHeapify(arr, index);


        }

        int getParent(int i)
        {
            return (i - 1) / 2;
        }
        void minHeapify(huffman[] arr, int i)
        {
            int min = i;

            
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < size && arr[left].data < arr[min].data)
                min = left;

            if (right < size && arr[right].data < arr[min].data)
                min = right;

            if (min != i)
            {
                huffman temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;

                minHeapify(arr, min);
            }
        }
    }
    class huffman_coding
    {
        huffman top;
        public huffman_coding()
        {
            string str = "aabc";
            start(str);


        }

        void start(string str)
        {
            Dictionary<char, int> dict = freq(str);

            huffman[] arr = getArrayFromDict(dict);
            minheap obj = new minheap(arr, arr.Length);

            buildTree(obj);
            printtree(top,"");

        }

        void printtree(huffman root,string str)
        {
            if (root == null)
                return;

            if (root.left == null && root.right == null)
            {
                Console.WriteLine(root.c+":"+str);
                
            }

            printtree(root.left, str + "0");
            printtree(root.right, str + "1");

        }

        void buildTree(minheap obj)
        {
           
            while(getSize(obj)>=1)
            {

               
                if(top==null)
                {
                    huffman left = obj.extractMin();
                    huffman right = obj.extractMin();
                    top = new huffman(left.data + right.data,'-');

                    top.left = left;
                    top.right = right;

                    obj.insert(left.data + right.data, '-');
                }
                else
                {
                    huffman left = obj.extractMin();
                    huffman right = top;

                    huffman obj_huff = new huffman(left.data + right.data, '-');
                    obj_huff.left = left;
                    obj_huff.right = right;

                    top = obj_huff;


                    obj.insert(left.data + right.data, '-');
                }
               
            }
        }
        

        int getSize(minheap obj)
        {
            int size = 0;

            for(int i=0;i<obj.size;i++)
            {
                if (obj.arr[i].c == '-') ;
                //size--;
                else
                    size++;
            }

            return size;
        }
        Dictionary<char,int> freq(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for(int i=0;i<str.Length;i++)
            {
                if (!dict.ContainsKey(str[i]))
                    dict.Add(str[i], 1);
                else
                    dict[str[i]]++;
            }

            dict.OrderBy(i => i.Value);

            return dict;
        }
    
        huffman[] getArrayFromDict(Dictionary<char, int> dict)
        {
            int index = 0;
            huffman[] arr = new huffman[dict.Count];

            foreach(KeyValuePair<char,int> pair in dict)
            {
                huffman obj = new huffman(pair.Value, pair.Key);
                arr[index] = obj;
                index++;
            }

            return arr;
        }
    }
}
