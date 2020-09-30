using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public static class Continue
    {
        #region Continue
        //  https://www.tutorialspoint.com/csharp/csharp_continue_statement.htm
        //  The continue statement in C# works somewhat like the break statement. 
        //  Instead of forcing termination, however, continue forces the next iteration of the loop to take place, skipping any code in between.

        #endregion
        public static void UsingContinue()
        {
            List<int> objNumbers = new List<int>();

            objNumbers.Add(1);
            objNumbers.Add(2);
            objNumbers.Add(3);

            List<int> objNumbersAdditional = new List<int>();
            objNumbersAdditional.Add(4);
            objNumbersAdditional.Add(5);

            objNumbers.AddRange(objNumbersAdditional);
            foreach (var item in objNumbers)
            {
                Console.WriteLine("BEFORE : Continue.. block of code...");

                if (item == 2)
                    continue;

                Console.WriteLine("AFTER : Continue.. block of code...");
            }
        }
    }
}
