using System;
using System.IO;

namespace Mutatio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            if (!Directory.Exists("patchs"))
            {
                Directory.CreateDirectory("patches");
            }
        }
    }
}
