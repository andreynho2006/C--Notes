using System;
namespace Csharp_Notes
{
    public struct Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex
            {
                Real = c1.Real + c2.Real,
                Imaginary = c1.Imaginary + c2.Imaginary
            };
        }
    }   
}
