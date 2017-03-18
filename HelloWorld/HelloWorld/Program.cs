using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello("David");
        }

        static void SayHello(string name)
        {
            Console.WriteLine("Hello, " + name);
        }
    }
}
