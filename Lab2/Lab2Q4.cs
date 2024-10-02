// Write an expression that calculates the area of a trapezoid by given sides a,b and height h.
namespace Lab2
{
    public class Q4
    {
        public static void run(string[] args)
        {
            Console.Write("Enter the length of side a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of side b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height h: ");
            double h = Convert.ToDouble(Console.ReadLine());

            double area = ((a + b) * h) / 2;

            Console.WriteLine("The area of the trapezoid is: " + area);
        }
    }
}