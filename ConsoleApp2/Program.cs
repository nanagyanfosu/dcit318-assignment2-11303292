using System;

abstract class Shape
{
    public abstract double GetArea();
}

class Circle(double radius) : Shape
{
    private double radius = radius;

    public override double GetArea()
    {
        return Math.PI * radius * radius;    
    }
}

class Rectangle(double length, double breadth) : Shape
{
    public double length = length, breadth = breadth;

    public override double GetArea() {
        return length * breadth;
    }
}
    class Program
    {
        static void Main()
        {
            Shape circle = new Circle(10);
            Console.WriteLine("Area of circle: " + circle.GetArea());
            Shape rectangle = new Rectangle(10, 20);
            Console.WriteLine("Area of rectangle: " + rectangle.GetArea());
        }


    }




