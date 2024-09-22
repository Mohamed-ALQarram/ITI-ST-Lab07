using System;

namespace Lab07
{
    public class Triangle:GeoShape
    {
        public double Base { get {return dim1; } set {dim1 = value; } }
        public double Height { get { return dim2; } set { dim2 = value; } }

        public Triangle():this(0,0) { } 
        public Triangle(double _base, double height):base(_base , height) {}

       
        public override double CalArea()
        {
            return (Base/2)*Height;
        }
    }
}
