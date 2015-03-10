using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

class CountingAWordInAText
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        byte[] inputBuffer = new byte[1024];
        string lookFor = Console.ReadLine();
        Stream inputStream = Console.OpenStandardInput(inputBuffer.Length);
        Console.SetIn(new StreamReader(inputStream, Console.InputEncoding, false, inputBuffer.Length));
        string userInput = Console.ReadLine(); ;
        Regex lookForParser = new Regex(@"\b" + lookFor + @"\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        List<string> result = new List<string>();
        MatchCollection matches = lookForParser.Matches(userInput);
        foreach (Match match in matches)
        {
            result.Add(match.Value);
        }
        Console.WriteLine(result.Count);
    }
}
