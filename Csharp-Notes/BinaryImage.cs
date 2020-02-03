using System;
namespace Csharp_Notes
{
    public class BinaryImage
    {
        private bool[] _pixels;

        //public static implicit operator ColorImage(BinaryImage im)
        //{
        //    return ColorImage(im);
        //}
        
        public static explicit operator bool[](BinaryImage im)
        {
            return im._pixels;
        }
    }
}
