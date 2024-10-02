// Write a program that reads three numbers from the console and prints the greatest of them.
namespace Lab3
{
    public class Q2
    {
        public static void run(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int greatest = num1;

            if (num2 > greatest)
            {
                greatest = num2;
            }

            if (num3 > greatest)
            {
                greatest = num3;
            }

            Console.WriteLine("The greatest number is: " + greatest);
        }
    }
}