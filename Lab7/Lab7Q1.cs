// Create a delegate name operations that takes two integers and returns an integer
// Implement two methods, Add and Subtract, that match the delegate signature
// Instantiate the delegate with each method and invoke it to perfrom addition and subtraction

namespace Lab7
{
    public class Q1
    {
        public delegate int Operations(int a, int b);

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static void run(string[] args)
        {
            Operations operation = Add;
            int result = operation(10, 5);
            Console.WriteLine($"Addition Result: {result}");

            operation = Subtract;
            result = operation(10, 5);
            Console.WriteLine($"Subtraction Result: {result}");
        }
    }
}