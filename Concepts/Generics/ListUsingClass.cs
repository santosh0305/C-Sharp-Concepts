using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Generics
{
    public class ListUsingClass
    {
        Products objProducts=new Products();

        public void GetProducts()
        {
            objProducts.productId = 100;
            objProducts.productName = "iPhone 7";
            objProducts.productTypes= new List<string>();
            objProducts.productTypes.Add("Product Type 1");
            objProducts.productTypes.Add("Product Type 2");

            foreach (var productType in objProducts.productTypes)
            {
                Console.WriteLine(productType);
            }
        }
    }

    public class Products
    {
        public int Cost { get; internal set; }
        public string Name { get; internal set; }
        public int productId { get; set; }
        public string productName { get; set; }
        public List<string> productTypes { get; set; }
        public int Stock { get; internal set; }
        public string Url { get; internal set; }
    }
}
