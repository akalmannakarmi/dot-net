// Modify the previous example to create a multi delegate that points to both Add and Subract methods
// Observe the output when the multicast delegate is invoked

namespace Lab7
{
    public class Q2
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
            Operations operations = Add;

            operations += Subtract;

            foreach (Operations operation in operations.GetInvocationList())
            {
                int result = operation(10, 5);
                Console.WriteLine($"Result: {result}");
            }
        }
    }
}