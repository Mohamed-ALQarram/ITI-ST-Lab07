using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    public class GeoShape
    {
        public double dim1;
        protected double dim2;

        public GeoShape():this(0,0) { }
        public GeoShape(double dim1, double dim2)
        {
            this.dim1 = dim1;
            this.dim2 = dim2;
        }

        public virtual double CalArea()
        {
            return 0;
        }
    }
}
