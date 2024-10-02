// Write a program that gets the coefficents a,b and c of a quadratic equation: ax2+bx+c.
// Calculate and print its real roots(if they exits). Quadratic equations may have 0,1 and 2 real roots
namespace Lab3{
    public class Q3
    {
        public static void run(string[] args)
        {
            Console.Write("Enter the coefficient a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the coefficient b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the coefficient c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("The quadratic equation has two real roots:");
                Console.WriteLine("Root 1: " + root1);
                Console.WriteLine("Root 2: " + root2);
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine("The quadratic equation has one real root:");
                Console.WriteLine("Root: " + root);
            }
            else
            {
                Console.WriteLine("The quadratic equation has no real roots.");
            }
        }
    }
}