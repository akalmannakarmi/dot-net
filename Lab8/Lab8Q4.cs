// Grouping with LINQ
// Write a program that groups employees by department and display the group name along with employee names.

namespace Lab8
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee(string name, string department)
        {
            Name = name;
            Department = department;
        }
    }

    public class Q4
    {
        public static void run(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee("Alice", "HR"),
                new Employee("Bob", "IT"),
                new Employee("Charlie", "IT"),
                new Employee("David", "HR"),
                new Employee("Eva", "Finance"),
                new Employee("Frank", "Finance"),
                new Employee("Grace", "IT")
            };

            var groupedEmployees = employees
                .GroupBy(e => e.Department)
                .ToList();

            Console.WriteLine("Employees grouped by department:");
            foreach (var group in groupedEmployees)
            {
                Console.WriteLine($"\nDepartment: {group.Key}");
                foreach (var employee in group)
                {
                    Console.WriteLine($"- {employee.Name}");
                }
            }
        }
    }
}