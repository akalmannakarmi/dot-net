// WAP to enter your first name, middle name, last name & print your full name.
namespace Lab1
{
    public class Q2
    {
        public static void run(string[] args)
        {
            Console.Write("Enter First Name: ");
            string fName = Console.ReadLine();
            Console.Write("Enter Middle Name: ");
            string mName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lName = Console.ReadLine();

            string fullName = fName + " " + mName + " " + lName;
            Console.WriteLine("Full Name: " + fullName);
        }
    }

}