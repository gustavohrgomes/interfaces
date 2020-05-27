using System;

using Course.Model.Entities;
using Course.Model.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape shape1 = new Circle() { Radius = 2.0, Color = Color.White };
            IShape shape2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.Black };

            Console.WriteLine(shape1);
            Console.WriteLine(shape2);

        }
    }
}
