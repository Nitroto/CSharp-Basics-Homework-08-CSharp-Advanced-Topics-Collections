using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

class ExtractURLsFromText
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Regex linkParser = new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        string userInput = Console.ReadLine();
        List<string> urls = new List<string>();
        MatchCollection matches = linkParser.Matches(userInput);
        foreach (Match match in matches)
        {
            urls.Add(match.Value);
        }
        foreach (string url in urls)
        {
            Console.WriteLine(url);
        }
    }
}
