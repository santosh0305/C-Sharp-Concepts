using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp
{
    #region Learnings
    //  On non-static class, you can have static method. To access it in main, use the class name.method name
    //  Constructor will only be called if we create object of the class using 'new'. so that you can use _names variable
    //  if you define public static List<string> _names-; you cannot instantiate _names object in constructor as its not instantiated yet
    
    //  Use List to store specific types if elements.
    //  You will have to instantiate it using 'new' keyword.
    //  You can have nulls & duplicate elements

    #endregion

    public class Generics_List
    {
        private static List<string> _names=new List<string>();
        public Generics_List()
        {
            _names.Add("Shirdi");
            _names.Add("Tirupathi");
            _names.Add("Tirupathi");    
            _names.Add("bhimashankar");
            if (!_names.Contains("bhimashankar"))
                _names.Add("bhimashankar");
        } 
        public List<string> GetNames()
        {
            foreach (var name in _names)
            {
                Console.WriteLine(name);
            }
            return _names;
        }
    }
    
    //partial class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        List<ListOfPersons> list1 = new List<ListOfPersons>();
    //        list1.Add(new ListOfPersons()
    //        {
    //            CompanyId = 6,
    //            ProductType = "GUL",
    //            ProductId = 126
    //        });
    //        list1.Add(new ListOfPersons()
    //        {
    //            CompanyId = 7,
    //            ProductType = "CAUL",
    //            ProductId = 127
    //        });

    //        List<ListOfPersons> list2 = new List<ListOfPersons>();
    //        list2.Add(new ListOfPersons()
    //        {
    //            CompanyId = 10,
    //            ProductType = "ABC",
    //            ProductId = 146
    //        });
    //        list2.Add(new ListOfPersons()
    //        {
    //            CompanyId = 7,
    //            ProductType = "CAUL",
    //            ProductId = 127
    //        });
    //        list2.Add(new ListOfPersons()
    //        {
    //            CompanyId = 7,
    //            ProductType = "CAUL",
    //            ProductId = 127
    //        });

    //        var duplicatedSSN =
    //                            from p in list2
    //                            group p by p.CompanyId into g
    //                            where g.Count() > 1
    //                            select g.Key;

    //        var duplicated = list2.FindAll(p => duplicatedSSN.Contains(p.CompanyId));
    //        duplicated.ForEach(dup => list2.Remove(dup));

    //        foreach (var item in duplicated)
    //        {
    //            Console.WriteLine("Duplicate Company Id : {0}",item.CompanyId);
    //        }

    //        Console.ReadLine();
    //    }
    //}

    public class ListOfPersons
    {
        public int ProductId { get; set; }
        public int CompanyId { get; set; }
        public string ProductType { get; set; }
    }
    
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<person> l1 = new List<person>()
    //        {
    //            new person (){age =10, name = "Aaaaa"},
    //            new person (){age =12, name = "Bbbbb"},
    //            new person (){age =13, name = "Ccccc"}, };

    //        List<person> l2 = new List<person>()
    //        {
    //            new person (){age =10, name = "Aaaaa"},
    //            new person (){age =11, name = "Ddddd"},
    //            new person (){age =13, name = "Ccccc"}, };

    //        List<person> result = (from l in l1
    //                                join m in l2 on new { l.age, l.name } equals new { m.age, m.name } into r
    //                                from g in r.DefaultIfEmpty()
    //                                where g == null
    //                                select l).ToList();

    //        foreach (var itemPerson in result)
    //        {
    //            Console.WriteLine(" Age : {0} and Name: {1} ",itemPerson.age, itemPerson.name);
    //        }
    //        Console.ReadLine();
    //    }
    //}

    class person
    {
        public int age { get; set; }
        public string name { get; set; }        
    }
}
