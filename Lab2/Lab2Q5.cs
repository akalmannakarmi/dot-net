// Write a program that prints on the console the perimeter and the area of a rectangle given side and height entered by the user.
namespace Lab2
{
    public class Q5
    {
        public static void run(string[] args)
        {
            Console.Write("Enter the length of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of the rectangle: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double perimeter = 2 * (width + height);
            double area = width * height;

            Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
            Console.WriteLine("The area of the rectangle is: " + area);
        }
    }
}