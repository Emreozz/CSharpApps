using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Shape> shapeList= new List<Shape>();
            List<double> doubleList= new List<double>();
            shapeList.Add(new Circle(50, 50));
            shapeList.Add(new Triangle(20, 50));
            shapeList.Add(new Rectangle(100, 5));

            foreach (Shape shape in shapeList)
                doubleList.Add(shape.CalculateSurface());
            foreach(double d in doubleList)
                Console.WriteLine(d);
            Console.ReadLine();
        }
    }
}
