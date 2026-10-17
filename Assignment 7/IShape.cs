using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{

    interface IShape
    {
        double Area { get; }

        void Draw();

        void PrintDetails()
        {
            Console.WriteLine($"Shape Area = {Area}");
        }
    }

}
