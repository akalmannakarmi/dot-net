// Declare two variavles of type int. Assign to them values 5 and 10 respectively/
// Exchange(swap) their values and print them
namespace Lab2
{
    public class Q3
    {
        public static void run(string[] args)
        {
            int firstVariable = 5;
            int secondVariable = 10;

            Console.WriteLine("Before swapping:");
            Console.WriteLine("firstVariable = " + firstVariable);
            Console.WriteLine("secondVariable = " + secondVariable);

            int temp = firstVariable;
            firstVariable = secondVariable;
            secondVariable = temp;

            Console.WriteLine("After swapping:");
            Console.WriteLine("firstVariable = " + firstVariable);
            Console.WriteLine("secondVariable = " + secondVariable);
        }
    }
}