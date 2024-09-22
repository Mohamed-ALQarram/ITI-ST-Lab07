using System;

namespace Lab07
{
    public class Rectangle : GeoShape
    {
        public double Height { get { return dim1; } set {dim1 = value; } }
        public double Width { get { return dim2; } set {dim2 = value; } }

        public Rectangle():this(0,0) { }
        public Rectangle(double height, double width):base(height, width) { }
        
        public override double CalArea()
        {
            return Width * Height;
        }
    }
}
