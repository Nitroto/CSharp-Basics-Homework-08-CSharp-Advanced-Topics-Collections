using System;
using System.Globalization;
using System.Linq;
using System.Threading;

class CountOfLetters
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        char[] userInput = Console.ReadLine().Split().Select(x => char.Parse(x)).ToArray();
        int[] frequencies = new int[char.MaxValue];
        foreach (char letter in userInput)
        {
            frequencies[letter]++;
        }
        for (int i = 0; i < char.MaxValue; i++)
        {
            if (frequencies[i] > 0 && char.IsLetterOrDigit((char)i))
            {
                Console.WriteLine("{0} -> {1}", (char)i, frequencies[i]);
            }
        }
    }
}
