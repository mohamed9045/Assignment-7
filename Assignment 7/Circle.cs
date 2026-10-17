using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{


    class Circle : IShape
    {
        public double Radius { get; set; }

        public double Area
        {
            get { return Math.PI * Radius * Radius; }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }

}
