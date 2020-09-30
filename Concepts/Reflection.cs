using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CSharp
{
    public class Reflection
    {
        public void ReadTypesUsingReflection()
        {
            int x = 10;
            string y = "Santosh";
            List<string> objProducts = new List<string>();

            Console.WriteLine(x.GetType());
            Console.WriteLine(y.GetType());
            Console.WriteLine(objProducts.GetType());
            
            // Get property array
            var properties = GetProperties(objProducts);

            foreach (var p in properties)
            {
                string name = p.Name;
                var value = p.GetValue(objProducts, null);
            }            
        }
        
        private static PropertyInfo[] GetProperties(object obj)
            {
                return obj.GetType().GetProperties();
            }
    }
}
