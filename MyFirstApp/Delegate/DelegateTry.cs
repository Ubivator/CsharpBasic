using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.Delegate
{
    //Declaration of the delegatis
    delegate void Printer(string printValue);

    class DelegateTry
    {
        
        public static void PrintV (string printValue)
        {
            Console.WriteLine($"This is value with I need to print: " + printValue );
        }
    }
}
