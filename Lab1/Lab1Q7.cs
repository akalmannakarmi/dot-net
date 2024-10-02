// WAP to print all the even numbers in decending order between 1 to 100
namespace Lab1
{
    public class Q7
    {
        public static void run(string[] args)
        {
            Console.WriteLine("Even Numbers in decending Order:");
            for (int i = 100; i > 0; i -= 2)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }
    }
}