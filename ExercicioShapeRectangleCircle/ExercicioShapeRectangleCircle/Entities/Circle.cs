using System;
using ExercicioShapeRectangleCircle.Entities.Enums;

namespace ExercicioShapeRectangleCircle.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
