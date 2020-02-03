using System;

namespace Csharp_Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Complex a = new Complex() { Real = 1, Imaginary = 2 };
            Complex b = new Complex() { Real = 4, Imaginary = 8 };
            Complex c = a + b;
            //Console.WriteLine(c.Real);
            Student student1 = new Student();
            Student student2 = new Student();
            student1.Name = "Andrei";
            student2.Name = "Simona";
            bool equals = student1.Equals(student2);
            Console.WriteLine("Student1 si student2 have the same name?");
            Console.WriteLine(equals);
        }
    }
}
