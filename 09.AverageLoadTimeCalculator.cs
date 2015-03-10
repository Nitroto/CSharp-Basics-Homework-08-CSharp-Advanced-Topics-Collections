using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

class AverageLoadTimeCalculator
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Dictionary<string, List<double>> sitesLoadTime = new Dictionary<string, List<double>>();
        string[] userInput = Console.ReadLine().Split();
        bool run = userInput[0] != "End";
        while (run)
        {
            if (!sitesLoadTime.ContainsKey(userInput[2])&&run)
            {
                sitesLoadTime.Add(userInput[2], new List<double>());
                sitesLoadTime[userInput[2]].Add(double.Parse(userInput[3]));
            }
            else
            {
                sitesLoadTime[userInput[2]].Add(double.Parse(userInput[3]));
            }
            userInput = Console.ReadLine().Split();
            run = userInput[0] != "End";
        }
        foreach (string key in sitesLoadTime.Keys)
        {
            double[] time = sitesLoadTime[key].ToArray();
            Console.WriteLine("{0} -> {1}", key, (time.Sum()/time.Length));
        }
    }
}
