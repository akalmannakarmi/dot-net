// WAP to enter two integer numbers & print the smallest one & largest one.
namespace Lab1
{
    public class Q6
    {
        public static void run(string[] args)
        {
            Console.Write("Enter First Number:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number:");
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Smallest Number: " + b);
                Console.WriteLine("Largest Number: " + a);
            }
            else
            {
                Console.WriteLine("Smallest Number: " + a);
                Console.WriteLine("Largest Number: " + b);
            }
        }
    }
}