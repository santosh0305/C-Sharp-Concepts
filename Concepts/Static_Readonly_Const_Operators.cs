using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp
{
    public static class Static_Readonly_Const_Operators
    {
        private static string FirstName="santosh";

        private static readonly string MiddleName = "kumar";

        private const int Age = 35;

        public static void GetStatic_Readonly_Const_Operators()
        {
            Console.Write("FirstName :" + FirstName);
            FirstName = FirstName.ToUpper();

            Console.Write("MiddleName :" + MiddleName);
            //MiddleName = MiddleName.ToUpper();

            Console.Write("Age :" + Age);
        }
    }
}
