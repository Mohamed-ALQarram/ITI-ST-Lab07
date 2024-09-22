using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    public class Circule: GeoShape
    {
       public double Radius { get {return  dim1; } set {dim1 = dim2 = value; } }

        public Circule():this(0) { }
        public Circule(double radius):base(radius , radius) { }
        public override double CalArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
