// Write a program to enter any five integer numbers into an array & display their sum
namespace Lab4
{
    public class Q1
    {
        public static void run(string[] args)
        {

            int[] numbers = new int[5];
            int sum = 0;

            Console.WriteLine("Enter 5 integer numbers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }

            Console.WriteLine($"The sum of the entered numbers is: {sum}");
        }
    }
}