// WAP to print the multiplication table of input number
namespace Lab1
{
    public class Q10
    {
        public static void run(string[] args)
        {
            Console.Write("Enter Number:");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(a + " x " + i + " = " + (a * i));
            }
        }
    }

}