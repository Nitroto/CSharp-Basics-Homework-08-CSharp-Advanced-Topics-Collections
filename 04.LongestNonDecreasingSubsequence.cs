using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class LongestNonDecreasingSubsequence
{
    static void Main() // This code doesn't work perfect. Result of last example should be "3 4 5 6 7 8 9" but the result is "3 4 5 6 7 8 16"
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        var subsets = GetSubsets(numbers.ToList());
        List<int> result = new List<int>();
        foreach (var set in subsets)
        {
            bool setIsOk = true;
            bool isEqual = false;
            bool isIncreasing = false;
            for (int i = 0; i < set.Count - 1; i++)
            {
                if (set[i] < set[i + 1] && !isEqual)
                {
                    isIncreasing = true;
                }
                else if (set[i] == set[i + 1] && !isIncreasing)
                {
                    isEqual = true;
                }
                else
                {
                    setIsOk = false;
                }
            }
            if (setIsOk && result.Count < set.Count)
            {
                result = set;
            }
        }
        foreach (int num in result)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
    }
    static List<List<T>> GetSubsets<T>(IEnumerable<T> Set)
    {
        var set = Set.ToList<T>();
        // Init list
        List<List<T>> subsets = new List<List<T>>();
        subsets.Add(new List<T>()); // add the empty set
        // Loop over individual elements
        for (int i = 1; i < set.Count; i++)
        {
            subsets.Add(new List<T>() { set[i - 1] });
            List<List<T>> newSubsets = new List<List<T>>();

            // Loop over existing subsets
            for (int j = 0; j < subsets.Count; j++)
            {
                var newSubset = new List<T>();
                foreach (var temp in subsets[j])
                    newSubset.Add(temp);
                newSubset.Add(set[i]);
                newSubsets.Add(newSubset);
            }
            subsets.AddRange(newSubsets);
        }
        // Add in the last element
        subsets.Add(new List<T>() { set[set.Count - 1] });
        return subsets;
    }
}
