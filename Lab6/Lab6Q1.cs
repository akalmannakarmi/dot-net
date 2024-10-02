// Define an abstract class Shape with abstract method CalculateSurface() and fields width and height.
// Define two additional classes for a triangle and a rectangle, which implement CalculateSurface().
// This method has to return the areas of the rectangle (height*width) and the triangle (height*width/2).
// Define a class for a circle with an appropriate constuctor, which initializes the two fields (height and width)
// with the same value (the radius) and implement the abstract method for calculating the area.
// Create an array of different shapes and calculate the area of each shape in another array

namespace Lab6
{
    public class Q1
    {
        public static void run(string[] args)
        {
            Shape[] shapes = new Shape[]
            {
            new Triangle(3, 4),
            new Rectangle(4, 5),
            new Circle(5)
            };

            double[] areas = new double[shapes.Length];

            for (int i = 0; i < shapes.Length; i++)
            {
                areas[i] = shapes[i].CalculateSurface();
            }

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine($"The area of shape {i + 1} ({shapes[i].GetType().Name}) is {areas[i]}");
            }
        }
    }

    abstract class Shape{
        protected double Width { get; set; }
        protected double Height { get; set; }

        public Shape(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public abstract double CalculateSurface();
    }

    class Triangle : Shape{
        public Triangle(double width, double height) : base(width, height) { }

        public override double CalculateSurface()
        {
            return (Width * Height) / 2;
        }
    }

    class Rectangle : Shape{
        public Rectangle(double width, double height) : base(width, height) { }

        public override double CalculateSurface()
        {
            return Width * Height;
        }
    }

    class Circle : Shape{
        public Circle(double radius) : base(radius, radius) { }

        public override double CalculateSurface()
        {
            return Math.PI * Width * Width;
        }
    }

}