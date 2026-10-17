using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{

    class Rectangle : Shape, IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public double Area
        {
            get { return Length * Width; }
        }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }
    }

}
