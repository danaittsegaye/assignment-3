//class exercise

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labbbb
{
    abstract class Shape
    {
        public abstract double calculateArea();
        public abstract double calculatePerimeter();


    }
    class Circle : Shape
    {
        static readonly double pi = 3.14;
        public double radius { get; set; }
        public override double calculateArea()

        {
            return (pi * radius * radius);
        }

        public override double calculatePerimeter()
        {
            return (2 * pi * radius);
        }

    }
    class Square : Shape
    {
        public double length { get; set; }
        public override double calculateArea()
        {
            return (length * length);
        }

        public override double calculatePerimeter()
        {
            return (4 * length);
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Circle c = new Circle { radius = 10 };
                Square s = new Square { length = 10 };
                Console.WriteLine("The area of the circle is :  " + c.calculateArea());//Output = circle area
                Console.WriteLine("The perimeter of the circle is :  " + c.calculatePerimeter());//output =circle perimeter
                Console.WriteLine("The area of the square is :  " + s.calculateArea());// output = square area
                Console.WriteLine("The perimeter of the square is :  " + s.calculatePerimeter());//output = square perimeter



            }
        }
    }
}

