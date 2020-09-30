using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp
{
    delegate void D(string value);
    
    public class Delegates
    {
        // ... Specify delegate with lambda expression.
        D d = v => Console.WriteLine(v);
        
        // ... Invoke delegate.
        //d.Invoke("cat");
    }
}
