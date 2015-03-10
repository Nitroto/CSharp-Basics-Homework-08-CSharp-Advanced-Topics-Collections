using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class RemoveNames
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        List<string> firstList = Console.ReadLine().Split().ToList();
        List<string> secondList = Console.ReadLine().Split().ToList();
        foreach (string name in secondList)
        {
            firstList.RemoveAll(item =>item==name);
        }
        foreach (string name in firstList)
        {
            Console.Write("{0} ", name);
        }
        Console.WriteLine();
    }
}
