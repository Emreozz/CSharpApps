using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        public abstract double CalculateSurface();
        public abstract int Width { get; set; }
        public abstract int Height { get; set; }


    }
}
