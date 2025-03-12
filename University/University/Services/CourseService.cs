namespace University
{
    public class CourseService : ICourseService
    {

        public void AddCourse(string courseName)
        {
            Console.WriteLine($"Course {courseName} added to the list");
        }

        public void RemoveCourse(string courseName)
        {
            Console.WriteLine($"Course {courseName} removed from the list");
        }
    }

}
