using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CSharp
{
    #region Learning of Dictionary
    //  Cannot have duplicate keys.  Error : An item with the same key has already been added.
    //  
    #endregion

    public class Generics_Dictionary
    {
        Dictionary<int, string> objDictionary = new Dictionary<int, string>();

        public void WorkingWithDictionary()
        {
            objDictionary.Add(1,"iphone 7");
            if (!objDictionary.ContainsKey(1))
            {
                // yield break;
                objDictionary.Add(1, "iphone 7");
            }
            else
            {
                objDictionary.Add(2, "iPhone 5");
            }

            Console.WriteLine("----------Printing Keys----------");
            foreach (var key in objDictionary.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("----------Printing Values----------");
            foreach (var value in objDictionary.Values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
