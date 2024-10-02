// Declare several constuctors for the class Student, which have different lists of parameters
// (fir complete information about a student or part of it). Data, whichhas no initial value to be
// initialized with null. Use nullable types for all non-mandatory data.
namespace Lab5
{
    public class Q2
    {
        public static void run(string[] args)
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
            Console.WriteLine("Created Student!");
        }

        public class Student
        {
            public string FullName;
            public string? Course;
            public string? Subject;
            public string? University;
            public string? Email;
            public string? PhoneNumber;

            public Student(string fullName, string? course, string? subject, string? university, string? email, string? phoneNumber)
            {
                FullName = fullName;
                Course = course;
                Subject = subject;
                University = university;
                Email = email;
                PhoneNumber = phoneNumber;
            }

            public Student(string fullName, string? course)
                : this(fullName, course, null, null, null, null) { }

            public Student(string fullName, string? course, string? subject)
                : this(fullName, course, subject, null, null, null) { }

            public Student(string fullName, string? course, string? subject, string? university)
                : this(fullName, course, subject, university, null, null) { }

            public Student(string fullName, string? course, string? subject, string? university, string? email)
                : this(fullName, course, subject, university, email, null) { }
        }
    }
}