using System.Collections.Generic;
using System.Collections;

namespace PracticeC_
{
    public class UnionInters
    {
        public List<int> arrayIntersection(int[] first, int[] second)
        {
            List<int> intersect = new List<int>();
            // logic here
            for (int i = 1; i < first.Length; i++)
            {
                for (int j = 1; j < second.Length; j++)
                {
                    if (first[i] == second[j])
                    {
                        intersect.Add(first[i]);
                    }
                }
            }
            return intersect;
        }

        public List<int> arrayUnion(int[] first, int[] second)
        {
            Hashtable hashtable = new Hashtable();
            List<int> result = new List<int>();
            foreach (var element in first)
            {
                hashtable.Add(element, element);
            }
            foreach (var element in second)
            {
                if (!(hashtable.Contains(element)))
                {
                    hashtable.Add(element, element);
                }

            }
            foreach (DictionaryEntry element in hashtable)

            {
                result.Add(int.Parse(element.Key.ToString())); ;

            }
            result.Sort();
            return result;
        }
    }
}
