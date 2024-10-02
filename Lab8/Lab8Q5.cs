// LINQ with Aggregation
// Write a program that calculates the sum of a list of integers using LINQ

namespace Lab8
{
    public class Q5
    {
        public static void run(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int sum = numbers.Sum();

            Console.WriteLine($"The sum of the numbers is: {sum}");
        }
    }
}