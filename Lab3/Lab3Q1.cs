// Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exists,
// such that the remainder of their division by 5 is 0. Example: in the range (14,25) there are 3 such numbers: 15,20,25
namespace Lab3
{
    public class Q1
    {
        public static void run(string[] args)
        {
            Console.Write("Enter the first integer number: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer number: ");
            int end = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"There are {count} numbers between {start} and {end} that are divisible by 5.");
        }
    }
}