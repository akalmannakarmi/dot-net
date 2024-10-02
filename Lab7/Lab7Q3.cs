// Create a method Calculate that takes two integers and a delegate of type Operation as parameters.
// Use this method to perfrom different operations by passing different delegate instances

namespace Lab7
{
    public class Q3
    {
        public delegate int Operations(int a, int b);

        public static int Calculate(int a, int b, Operations operation)
        {
            return operation(a, b);
        }

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
            int result = Calculate(10, 5, Add);
            Console.WriteLine($"Addition Result: {result}");

            result = Calculate(10, 5, Subtract);
            Console.WriteLine($"Subtraction Result: {result}");

            result = Calculate(10, 5, (a, b) => a * b);
            Console.WriteLine($"Multiplication Result: {result}");
        }
    }
}