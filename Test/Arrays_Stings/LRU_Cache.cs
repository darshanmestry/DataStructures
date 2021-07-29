using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Arrays_Stings
{
    
    class LRU_Cache
    {
        int CacheSize;
        LinkedList<int> cache;
        HashSet<int> hashSet;
        public LRU_Cache()
        {
            /*
             We are given total possible page numbers that can be referred. We are also given cache (or memory) 
            size (Number of page frames that cache can hold at a time). 
            The LRU caching scheme is to remove the least recently used frame when the cache is full and a new page is referenced which is not there in cache
             */

            CacheSize = 4;
            cache = new LinkedList<int>(); ;
            hashSet=new HashSet<int>();

            refer(1);
            refer(2);
            refer(3);
            refer(1);
            refer(4);
            refer(5);
           


            displayCache();
            
        }

        void refer(int page)
        {
            if(!hashSet.Contains(page))
            {
                if(cache.Count==CacheSize)
                {
                    int last = cache.Last();

                    cache.RemoveLast();

                    hashSet.Remove(last);
                }

            }
            else
            {
                cache.Remove(page);
            }
           
            cache.AddFirst(page);

            if (!hashSet.Contains(page))
                hashSet.Add(page);

        }

        void displayCache()
        {
            for (int i = 0; i < cache.Count; i++)
                Console.Write(cache.ElementAt(i) + " ");
        }
   
        void practise(int page)
        {


            if(!hashSet.Contains(page)) //new page
            {
                if(cache.Count==CacheSize) //cache alrady full
                {
                    int last = cache.Last();
                    cache.RemoveLast(); //remove from hashset
                    hashSet.Remove(last);//remove from hashset
                }
                hashSet.Add(page);
            }
            else    //Page already in hashset
            {
                //remove from cahche
                cache.Remove(page);
            }

            cache.AddFirst(page);
        }
    }
}
