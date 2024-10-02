// Basic LINQ Query
// Write a program that filters and selects even & odd numbers from an array of integers


namespace Lab8
{
    public class Q1
    {
        public static void run(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = numbers.Where(n => n % 2 == 0).ToArray();
            var oddNumbers = numbers.Where(n => n % 2 != 0).ToArray();

            Console.WriteLine("Even Numbers:");
            foreach (var even in evenNumbers)
            {
                Console.WriteLine(even);
            }

            Console.WriteLine("Odd Numbers:");
            foreach (var odd in oddNumbers)
            {
                Console.WriteLine(odd);
            }
        }
    }
}