using CSharp.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp
{
    public class LINQ
    {
        private void SomeMethod()
        {
            DictionaryUse();

            ListUse();

            Console.WriteLine("---------------------All done---------------------");
            Console.ReadLine();
        }

        private static void ListUse()
        {
            UseWhereAndFindAll();
            Console.ReadLine();

            ModifyMultipleItemsInForEach();
            Console.ReadLine();
        }

        private static void UseWhereAndFindAll()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            var evenNumbers = numbers.FindAll(x => x % 2 == 0);
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }

            var result = numbers.Where(x => x % 2 == 0);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            numbers.ForEach(x =>
            {
                x = x * 10;
                return;
            });

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }

        private static void ModifyMultipleItemsInForEach()
        {
            List<Products> products = new List<Products>();
            products.Add(new Products()
            {
                Name = "Iphone",
                Cost = 64500,
                Stock = 10,
                Url = "url"
            });

            products.Add(new Products()
            {
                Name = "Samaung",
                Cost = 64523,
                Stock = 0,
                Url = "url samsung"
            });

            products.ForEach(x =>
            {
                x.Cost = x.Cost * 2;
                x.Name = x.Name + " is product name.";
                return;
            });
            foreach (var item in products)
            {
                Console.WriteLine(item.Cost);
                Console.WriteLine(item.Name);
            }
        }

        private static void DictionaryUse()
        {
            Dictionary<int, string> employees = new Dictionary<int, string>();
            employees.Add(1, "Santosh");
            employees.Add(2, "Ganesh");
            employees.Add(3, "Srinu");

            var users = employees.Select(x => x.Value.Contains("t")).ToList();

            Console.WriteLine(users.Count);
        }
    }
}
