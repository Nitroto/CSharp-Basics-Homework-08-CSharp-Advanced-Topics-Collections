using System;
using System.Globalization;
using System.Threading;

class LongestAreaInArray
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        string[] words = new string[n];
        int longestArea = int.MinValue;
        string element = string.Empty;
        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine();
        }
        for (int i = 0; i < words.Length; i++)
        {
            int counter = 1;
            for (int j = i+1; j < words.Length; j++)
            {
                if (words[i] == words[j]&& words[i]!=null)
                {
                    counter++;
                    words[j] = null;
                }
                else
                {
                    break;
                }
            }
            if (counter > longestArea)
            {
                longestArea = counter;
                element = words[i];
            }
        }
        Console.WriteLine(longestArea);
        for (int i = 0; i < longestArea; i++)
        {
            Console.WriteLine(element);
        }
    }
}
