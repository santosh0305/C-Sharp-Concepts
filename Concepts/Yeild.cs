using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp
{
    #region MyRegion
    //  You cannot have the yield return statement in a try-catch block though you can have it inside a try-finally block
    //  You cannot have the yield break statement inside a finally block
    //  The return type of the method where yield has been used, should be IEnumerable, IEnumerable<T>, IEnumerator, or IEnumerator<T>
    //  You cannot have a ref or out parameter in your method in which yield has been used
    //  You cannot use the "yield return" or the "yield break" statements inside anonymous methods
    //  You cannot use the "yield return" or the "yield break" statements inside "unsafe" methods, i.e., methods that are marked with the "unsafe" keyword to denote an unsafe context
    #endregion

    public static class YeildEx
    {
        public static void Numbers()
        {
            //foreach (var item in GenerateNumbers())
            //{
            //    Console.WriteLine(item);
            //}
        }

        //public static void GenerateNumbers()
        //{
        //    List<int> objNumbers = new List<int>();

        //    for (int x = 0; x < 10; x++)
        //    {
        //        yield return x;
        //        objNumbers.Add(x);
        //    }

        //}
    }
}
