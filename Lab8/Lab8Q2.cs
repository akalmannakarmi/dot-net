// LINQ on Objects
// Write a program that selects students with marks above 90 from a list of students

namespace Lab8
{
    public class Student
    {
        public string Name { get; set; }
        public int Marks { get; set; }

        public Student(string name, int marks)
        {
            Name = name;
            Marks = marks;
        }
    }

    public class Q2
    {
        public static void run(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Alice", 85),
                new Student("Bob", 92),
                new Student("Charlie", 78),
                new Student("David", 95),
                new Student("Eva", 88),
                new Student("Frank", 91)
            };

            var topStudents = students.Where(s => s.Marks > 90).ToList();

            Console.WriteLine("Students with marks above 90:");
            foreach (var student in topStudents)
            {
                Console.WriteLine($"{student.Name} - {student.Marks}");
            }
        }
    }
}