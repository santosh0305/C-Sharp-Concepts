using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp
{
    public class Collections_ArrayList
    {
        #region MyRegion
        // https://www.tutorialspoint.com/csharp/csharp_arraylist.htm
        #endregion

        public void ReadArrayList()
        {
            ArrayList arProducts = new ArrayList();

            arProducts[0] = "Samsung C9 Pro";
            arProducts[1] = "Samsung A9 Pro";

            foreach (var item in arProducts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
