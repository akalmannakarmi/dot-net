// Write a program to enter any 10 integer numbers into an array &
// print the sum of all even numbers & odd numbers in it.
namespace Lab4
{
    public class Q4
    {
        public static void run(string[] args)
        {
            int[] numbers = new int[10];
            int sumEven = 0;
            int sumOdd = 0;

            Console.WriteLine("Enter 10 integer numbers:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i] % 2 == 0)
                {
                    sumEven += numbers[i];
                }
                else
                {
                    sumOdd += numbers[i];
                }
            }

            Console.WriteLine($"The sum of all even numbers is: {sumEven}");
            Console.WriteLine($"The sum of all odd numbers is: {sumOdd}");
        }
    }
}