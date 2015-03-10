using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class CountOfNames
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        List<string> names = Console.ReadLine().Split().ToList();
        names.Sort();
        Dictionary<string, int> countNames = new Dictionary<string, int>();
        for (int i = 0; i < names.Count; i++)
        {
            int count = 1;
            if (names[i] != null)
            {
                countNames.Add(names[i], 0);
                for (int j = i + 1; j < names.Count; j++)
                {
                    if (names[i] == names[j])
                    {
                        count++;
                        names[j] = null;
                    }
                }
                countNames[names[i]] = count;
            }
        }
        foreach (string key in countNames.Keys)
        {
            Console.WriteLine("{0} -> {1}", key, countNames[key]);
        }
    }
}
