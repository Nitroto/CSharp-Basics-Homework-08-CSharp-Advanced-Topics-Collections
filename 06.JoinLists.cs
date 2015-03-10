using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class JoinLists
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        List<int> firstList = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
        List<int> secondList = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
        List<int> resultList = firstList.Union(secondList).ToList();
        resultList.Sort();
        foreach (int number in resultList)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
    }
}
