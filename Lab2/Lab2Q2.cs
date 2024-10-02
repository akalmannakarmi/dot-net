// Declare two variables of type string and assign them a value "The "use" of quotations causes difficultiess." (without the outer quotes).
// In one of them variables use quoted string and int the other do not use it.
namespace Lab2
{
    public class Q2
    {
        public static void run(string[] args)
        {
            string quotedString = "The \"use\" of quotations causes difficulties.";
            string regularString = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine("Quoted String:"+quotedString);
            Console.WriteLine("Regular String:"+regularString);
        }
    }
}