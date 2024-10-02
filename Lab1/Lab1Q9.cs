// WAP to print the day of the week based on the input 1 to 7
namespace Lab1
{
    public class Q9
    {
        public static void run(string[] args)
        {
            Console.Write("Enter Day of week(1-7): ");
            int d = int.Parse(Console.ReadLine());

            switch (d)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid Day of the Week");
                    break;
            }
        }
    }
}