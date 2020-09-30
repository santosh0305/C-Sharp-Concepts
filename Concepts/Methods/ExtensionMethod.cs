using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp
{
    public static class ExtensionMethod
    {
        public static void ConvertToUpperCaseExtnsionMethod()
        {
            var result = Console.ReadLine();
            string UpperResult = result.DoUpper(result);    // This is the extension method
            string LowerResult = result.DoLower(result);

            Console.WriteLine("UpperResult : " + UpperResult);
            Console.WriteLine("LowerResult : " + LowerResult);
        }

        private static string DoUpper(this string result, string res)   // See the icon for Extension Method
        {
            return res.ToUpper();
        }

        private static string DoLower(this string result,string res)
        {
            return res.ToLower();
        }
    }
    
    public static class ExtensionMethods
    {
        public static string UppercaseFirstLetter(this string value)
        {
            // Uppercase the first letter in the string.
            if (value.Length > 0)
            {
                char[] array = value.ToCharArray();
                array[0] = char.ToUpper(array[0]);
                return new string(array);
            }
            return value;
        }
    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        // Use the string extension method on this value.
    //        string value = "dot net perls";
    //        value = value.UppercaseFirstLetter();
    //        Console.WriteLine(value);
    //    }
    //}

}
