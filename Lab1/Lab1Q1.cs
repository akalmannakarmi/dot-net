// WAP to enter principal, time, rate & calculate Simple Interest & Amount
namespace Lab1
{
    public class Q1
    {
        public static void run(string[] args)
        {
            Console.Write("Enter Principal: ");
            double p = double.Parse(Console.ReadLine());
            Console.Write("Enter Time: ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Enter Rate: ");
            double r = double.Parse(Console.ReadLine());

            double si = (p * t * r) / 100;
            Console.WriteLine("Simple Interest: "+si);
            Console.WriteLine("Amount: " + (p + si));
        }
    }
}