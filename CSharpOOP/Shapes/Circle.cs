using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle:Shape
    {
        public override int Width { get ; set; }
            
        public override int Height { get ; set ; }
        public Circle(int width,int height)
        {
            if (width == height)
            {

                this.Width = width;
                this.Height = height;
            }
            else
                throw new ArgumentException("height and width must have the same value");
        }


        public override double CalculateSurface()
        {
            return 3.14*this.Width*this.Height;
        }
    }
}
