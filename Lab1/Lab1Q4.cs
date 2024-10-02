// WAP to print the pattern 2,8,18,32 .. 10th term
namespace Lab1
{
    public class Q4
    {
        public static void run(string[] args)
        {
            Console.Write("Pattern of numbers:");
            for (int i = 1; i <= 10; i++)
            {
                int n = 2 * i * i;
                Console.Write(n + ", ");
            }
            Console.WriteLine();
        }
    }
}