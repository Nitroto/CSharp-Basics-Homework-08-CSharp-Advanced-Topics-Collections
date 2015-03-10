using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

class LongestWordInAText
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string userInput = Console.ReadLine();
        userInput = Regex.Replace(userInput, @"[^\w\s]", string.Empty);
        string[] sentence = userInput.Split();
        int maxLength = int.MinValue;
        string longestWord = string.Empty;
        foreach (string word in sentence)
        {
            char[] letters = word.ToCharArray();
            if (letters.Length > maxLength)
            {
                maxLength = letters.Length;
                longestWord = new string(letters);
            }
        }
        Console.WriteLine("{0}", longestWord);
    }
}
