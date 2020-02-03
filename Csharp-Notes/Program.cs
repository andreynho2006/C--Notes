using System;

namespace Csharp_Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Complex a = new Complex() { Real = 1, Imaginary = 2 };
            Complex b = new Complex() { Real = 4, Imaginary = 8 };
            Complex c = a + b;
            Console.WriteLine(c.Real);
        }
    }
}
