using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Graph
{
    /*
     * Given a sorted dictionary (array of words) of an alien language, find order of characters in the language.

        Examples:  

        Input:  words[] = {"baa", "abcd", "abca", "cab", "cad"}
        Output: Order of characters is 'b', 'd', 'a', 'c'
        Note that words are sorted and in the given language "baa" 
        comes before "abcd", therefore 'b' is before 'a' in output.
        Similarly we can find other orders.

        Input:  words[] = {"caa", "aaa", "aab"}
        Output: Order of characters is 'c', 'a', 'b'

     {“aba”, “bba”, “aaa”}  invalid input
     */
    class given_a_sorted_dictionary_of_alien_characters_find_order_of_character
    {
        int v;
        Graph g;
        public given_a_sorted_dictionary_of_alien_characters_find_order_of_character()
        {
            string[] words = { "baa", "abcd", "abca", "cab", "cad" };
            v = words.Length;

            createGraph(words);
            topologicalSort();
        }

        void createGraph(string[] words)
        {
            g = new Graph(v);
            // Get adjacent words And Compare them Char by char for the mismatcg add edge from word1[j] --> word2[j]
            for(int i=0;i<words.Length-1;i++)
            {
                string word1 = words[i]; 
                string word2 = words[i+1];
                
                for(int j=0;j<Math.Min(word1.Length,word2.Length);j++)
                {
                    if(word1[j]!=word2[j])
                    {


                        //[b]->a
                        if (g.adj[word2[j] - 'a'].Find(word1[j] - 'a') == null) //while adding edge from a--> b check b--> a egde is not present,if yes then it is invald input
                        {
                            g.addEdge(word1[j] - 'a', word2[j] - 'a');
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                            System.Environment.Exit(0);
                        }
                    }
                }
            }

        }


        void topologicalSort()
        {
           bool[] visitedVertex = new bool[g.adj.Length];
           Stack<int> st = new Stack<int>();

            for(int i=0;i<g.adj.Length;i++)
            {
                if(!visitedVertex[i])
                {
                    util_topo(visitedVertex, st, i);
                }
            }

           
            while (st.Count > 0)
                Console.Write((char)(st.Pop()+'a') +" ");
        }

        void util_topo(bool[] visitedVertex,Stack<int> st,int vertex)
        {
            visitedVertex[vertex] = true;

            LinkedList<int> lis = g.adj[vertex];

            for(int i=0;i<lis.Count;i++)
            {
                if (!visitedVertex[lis.ElementAt(i)])
                    util_topo(visitedVertex, st, lis.ElementAt(i));
            }

            st.Push(vertex);
        }
    }
}
