// WAP to print the area of rectangle for the given length & breadth.
namespace Lab1
{
    public class Q5
    {
        public static void run(string[] args)
        {
            Console.Write("Enter Length:");
            double l = double.Parse(Console.ReadLine());
            Console.Write("Enter Breadth:");
            double b = double.Parse(Console.ReadLine());

            double area = l * b;
            Console.WriteLine("Area: " + area);
        }
    }
}