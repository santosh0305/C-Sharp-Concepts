using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        IEnumerable<int> result = from value in Enumerable.Range(0, 2)
                                  select value;

        // Loop
        foreach (int value in result)
        {
            Console.WriteLine(value);
        }

        // We can use extension methods on IEnumerable<int>
        double average = result.Average();

        // Extension methods can convert IEnumerable<int>
        List<int> list = result.ToList();
        int[] array = result.ToArray();
    }
}
