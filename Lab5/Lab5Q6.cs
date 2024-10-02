// Write a class StudentTest, Which has to test the functionality of the class Student.
namespace Lab5
{
    public class Q6
    {
        public static void run(string[] args)
        {
            StudentTest.test();
        }
    }
    public class StudentTest
    {
        public static void test()
        {
            // Test creating a student with full information
            Console.WriteLine("Testing Student with full information:");
            Student student1 = createStudent();
            student1.DisplayStudentDetails();
            Student.DisplayStudentCount();
            Console.WriteLine();

            // Test creating a student with full name and course
            Console.WriteLine("Testing Student with full name and course:");
            Student student2 = createStudent();
            student2.DisplayStudentDetails();
            Student.DisplayStudentCount();
            Console.WriteLine();

            // Test creating a student with full name, course, and subject
            Console.WriteLine("Testing Student with full name, course, and subject:");
            Student student3 = createStudent();
            student3.DisplayStudentDetails();
            Student.DisplayStudentCount();
            Console.WriteLine();

            // Test creating a student with full name, course, subject, and university
            Console.WriteLine("Testing Student with full name, course, subject, and university:");
            Student student4 = createStudent();
            student4.DisplayStudentDetails();
            Student.DisplayStudentCount();
            Console.WriteLine();

            // Test creating a student with full name, course, subject, university, and email
            Console.WriteLine("Testing Student with full name, course, subject, university, and email:");
            Student student5 = createStudent();
            student5.DisplayStudentDetails();
            Student.DisplayStudentCount();
            Console.WriteLine();

            // Test the number of students created
            Console.WriteLine("Final Student Count:");
            Student.DisplayStudentCount();
        }
        public static Student createStudent()
        {
            Console.Write("Enter Full Name: ");
            string fullName = Console.ReadLine();

            Console.Write("Enter Course (leave empty if not applicable): ");
            string? course = Console.ReadLine();
            course = string.IsNullOrWhiteSpace(course) ? null : course;

            Console.Write("Enter Subject (leave empty if not applicable): ");
            string? subject = Console.ReadLine();
            subject = string.IsNullOrWhiteSpace(subject) ? null : subject;

            Console.Write("Enter University (leave empty if not applicable): ");
            string? university = Console.ReadLine();
            university = string.IsNullOrWhiteSpace(university) ? null : university;

            Console.Write("Enter Email (leave empty if not applicable): ");
            string? email = Console.ReadLine();
            email = string.IsNullOrWhiteSpace(email) ? null : email;

            Console.Write("Enter Phone Number (leave empty if not applicable): ");
            string? phoneNumber = Console.ReadLine();
            phoneNumber = string.IsNullOrWhiteSpace(phoneNumber) ? null : phoneNumber;

            Student student;
            if (course == null)
            {
                student = new Student(fullName, null);
            }
            else if (subject == null)
            {
                student = new Student(fullName, course);
            }
            else if (university == null)
            {
                student = new Student(fullName, course, subject);
            }
            else if (email == null)
            {
                student = new Student(fullName, course, subject, university);
            }
            else if (phoneNumber == null)
            {
                student = new Student(fullName, course, subject, university, email);
            }
            else
            {
                student = new Student(fullName, course, subject, university, email, phoneNumber);
            }
            return student;
        }
        public class Student
        {
            public static int StudentCount { get; private set; } = 0;
            public string FullName { get; set; }
            public string? Course { get; set; }
            public string? Subject { get; set; }
            public string? University { get; set; }
            public string? Email { get; set; }
            public string? PhoneNumber { get; set; }

            public Student(string fullName, string? course, string? subject, string? university, string? email, string? phoneNumber)
            {
                FullName = fullName;
                Course = course;
                Subject = subject;
                University = university;
                Email = email;
                PhoneNumber = phoneNumber;
                StudentCount++;
            }

            public Student(string fullName, string? course)
                : this(fullName, course, null, null, null, null) { }

            public Student(string fullName, string? course, string? subject)
                : this(fullName, course, subject, null, null, null) { }

            public Student(string fullName, string? course, string? subject, string? university)
                : this(fullName, course, subject, university, null, null) { }

            public Student(string fullName, string? course, string? subject, string? university, string? email)
                : this(fullName, course, subject, university, email, null) { }

            public void DisplayStudentDetails()
            {
                Console.WriteLine($"Full Name: {FullName}");
                Console.WriteLine($"Course: {Course ?? "N/A"}");
                Console.WriteLine($"Subject: {Subject ?? "N/A"}");
                Console.WriteLine($"University: {University ?? "N/A"}");
                Console.WriteLine($"Email: {Email ?? "N/A"}");
                Console.WriteLine($"Phone Number: {PhoneNumber ?? "N/A"}");
            }
            public static void DisplayStudentCount()
            {
                Console.WriteLine($"Number of Students Created: {StudentCount}");
            }
        }
    }
}