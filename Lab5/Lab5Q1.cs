// Define a class Student, which contains the following information about students:
// fullname,course,subject, university, e0mail and phone number.
namespace Lab5
{
    public class Q1
    {
        public static void run(string[] args)
        {
            Console.Write("Enter Full Name: ");
            string fullName = Console.ReadLine();

            Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            Console.Write("Enter Subject: ");
            string subject = Console.ReadLine();

            Console.Write("Enter University: ");
            string university = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Student student = new Student(fullName, course, subject, university, email, phoneNumber);
            Console.WriteLine("Created Student!");
        }
        public class Student
        {
            public string FullName;
            public string Course;
            public string Subject;
            public string University;
            public string Email;
            public string PhoneNumber;

            public Student(string fullName, string course, string subject, string university, string email, string phoneNumber)
            {
                FullName = fullName;
                Course = course;
                Subject = subject;
                University = university;
                Email = email;
                PhoneNumber = phoneNumber;
            }
        }
    }
}