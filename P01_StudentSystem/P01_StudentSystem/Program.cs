using P01_StudentSystem.Data;
using P01_StudentSystem.Models;

namespace P01_StudentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentSystemContext context = new StudentSystemContext();
            { 

                
                Console.WriteLine("\nEnter student information:");
                var student = GetStudentInformation();
                context.Students.Add(student);
                context.SaveChanges();
                Console.WriteLine($"Student '{student.Name}' added with ID: {student.StudentId}");

               
                Console.WriteLine("\nEnter course information:");
                var course = GetCourseInformation();
                context.Courses.Add(course);
                context.SaveChanges();
                Console.WriteLine($"Course '{course.Name}' added with ID: {course.CourseId}");
            }
        }

        static Student GetStudentInformation()
        {
            Console.Write("Name: ");
            string studentName = Console.ReadLine();

            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Birthday (optional, format: YYYY-MM-DD): ");
            DateTime? birthday = TryParseDateTime(Console.ReadLine());

            return new Student
            {
                Name = studentName,
                PhoneNumber = phoneNumber,
                Birthday = birthday,
                RegisteredOn = DateTime.Now
            };
        }

        static Course GetCourseInformation()
        {
            Console.Write("Course Name: ");
            string courseName = Console.ReadLine();

            Console.Write("Course Description: ");
            string courseDescription = Console.ReadLine();

            Console.Write("Start Date (format: YYYY-MM-DD): ");
            DateTime startDate = (DateTime)TryParseDateTime(Console.ReadLine());

            Console.Write("End Date (format: YYYY-MM-DD): ");
            DateTime endDate = (DateTime)TryParseDateTime(Console.ReadLine());

            Console.Write("Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            return new Course
            {
                Name = courseName,
                Description = courseDescription,
                StartDate = startDate,
                EndDate = endDate,
                Price = price
            };
        }

        static DateTime? TryParseDateTime(string input)
        {
            if (DateTime.TryParse(input, out DateTime result))
            {
                return result;
            }
            return null;
        }

    }
}
