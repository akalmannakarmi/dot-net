// WAP to check wether the input number is print or not.
namespace Lab1
{
    public class Q8
    {
        public static void run(string[] args)
        {
            Console.Write("Enter Number:");
            int a = int.Parse(Console.ReadLine());
            int n = 2;

            while (n < a / 2)
            {
                if (a % n == 0)
                {
                    Console.WriteLine("Not Prime Number");
                    return;
                }
                n++;
            }
            Console.WriteLine("Is Prime Number");
        }
    }
}