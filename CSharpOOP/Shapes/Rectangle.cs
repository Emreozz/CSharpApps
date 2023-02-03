using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : Shape
    {
        public override int Width { get ; set ; }
        public override int Height { get ; set ; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateSurface()
        {
            return this.Height*this.Width;
        }
    }
}
