// Write a program that, depending on the user's choice, inputs int, double, string variable.
// If the variable is int or double, the program increases it by 1.
// If the varuable is string, the program appends "*" at the end.
// Print the result at the console. Use switch statement
namespace Lab3
{
    public class Q4
    {
        public static void run(string[] args)
        {
            Console.Write("Choose the type of variable to input (int, double, string): ");
            string choice = Console.ReadLine().ToLower();

            object result = null;

            switch (choice)
            {
                case "int":
                    Console.Write("Enter an integer: ");
                    int intValue = Convert.ToInt32(Console.ReadLine());
                    result = intValue + 1;
                    break;

                case "double":
                    Console.Write("Enter a double: ");
                    double doubleValue = Convert.ToDouble(Console.ReadLine());
                    result = doubleValue + 1;
                    break;

                case "string":
                    Console.Write("Enter a string: ");
                    string stringValue = Console.ReadLine();
                    result = stringValue + "*";
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose 'int', 'double', or 'string'.");
                    return;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}