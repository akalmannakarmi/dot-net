using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.Write("Enter the lab no:");
            string labNo = Console.ReadLine();
            Console.Write("Enter the question no:");
            string questionNo = Console.ReadLine();
            
            if (labNo == "" || questionNo =="") { break; }

            // Construct the full class name
            string className = $"Lab{labNo}.Q{questionNo}";

            try
            {
                // Get the type of the class
                Type type = Type.GetType(className);

                if (type != null)
                {
                    // Get the 'Run' method (static)
                    MethodInfo method = type.GetMethod("run", BindingFlags.Public | BindingFlags.Static);

                    if (method != null)
                    {
                        // Invoke the 'Run' method
                        Console.Clear();
                        Console.WriteLine($"Running Lab {labNo} Question {questionNo}...");
                        method.Invoke(null, new object[] { args });
                    }
                    else
                    {
                        Console.WriteLine($"'Run' method not found in {className}");
                    }
                }
                else
                {
                    Console.WriteLine($"Class {className} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            Console.ReadLine();
        }
    }
}
