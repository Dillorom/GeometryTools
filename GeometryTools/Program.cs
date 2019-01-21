using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTools
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square() { Width = 4 };
            var triangle = new Triangle() { Base = 4, Height = 3 };

            square.Display();
            triangle.Display();
            Console.ReadKey();
        }
    }
    
    abstract class Shape
    {
        public abstract int GetArea();
        public void Display()
        {
            Console.WriteLine("The area is {0} ", GetArea());
        }
    }

    class Square : Shape
    {
        public int Width;
        public override int GetArea()
        {
            return Width * Width;
        }
    }

    class Triangle : Shape
    {
        public int Base;
        public int Height;

        public override int GetArea()
        {
            return (Base * Height) / 2;
        }


    }


}
