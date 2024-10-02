// WAP to print the first ten natural numbers in decending order
namespace Lab1
{
    public class Q3
    {
        public static void run(string[] args)
        {
            Console.Write("First Ten Natural Numbers:");
            for (int i = 10; i > 0; i--)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }
    }
}