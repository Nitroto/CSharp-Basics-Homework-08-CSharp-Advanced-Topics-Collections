using System;
using System.Globalization;
using System.Threading;

class SortingNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbers);
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
