using System;

namespace ex4_28
{
    public class Rectangle
    {
        public int height;
        public int width;
        public override string ToString()
        {
            return string.Format("Width : {0}, Height : {1}", width, height);
        }
    }
}
