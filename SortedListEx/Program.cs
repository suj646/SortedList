using System;
using System.Collections;

namespace SortedListEx
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SortedList my_slist1 = new SortedList();
             my_slist1.Add(1.02, "my");
            my_slist1.Add(1.07, "name");
            my_slist1.Add(1.04, "is");
            my_slist1.Add(1.01, "khan");

            foreach (DictionaryEntry pair in my_slist1)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
            Console.WriteLine();
            SortedList my_slist2 = new SortedList() {
                                  { "b.01", 1 },
                                  { "b.02",2 },
                                  { "b.03", 3 },
                                  { "b.04", 4 }};

            foreach (DictionaryEntry pair in my_slist2)
            {
                Console.WriteLine("{0} and {1}",
                          pair.Key, pair.Value);
            }
        }

    }
}
