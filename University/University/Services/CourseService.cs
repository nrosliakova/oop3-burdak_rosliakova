namespace University
{
    public class CourseService : ICourseService
    {
        private List<string> Courses;
        private readonly Logger _logger;
        public CourseService()
        {
            Courses = new List<string>();
        }
        public void AddCourse(string courseName)
        {
            if (Courses.Contains(courseName))
            {
                Console.WriteLine($"Course {courseName} is already in the list");
            }
            else
            {
                Courses.Add(courseName);
                Console.WriteLine($"Course {courseName} added to the list");

            }
        }

        public void RemoveCourse(string courseName)
        {
            if (!Courses.Contains(courseName))
            {
                _logger.Message($"Course {courseName} does not exists in the list");
                throw new ArgumentException($"Course '{courseName}' does not exist in the list");

            }

            Courses.Remove(courseName);
            Console.WriteLine($"Course {courseName} removed from the list");

            //try
            //{
            //    Courses.Remove(courseName);
            //    Console.WriteLine($"Course {courseName} removed from the list");
            //}
            //catch(ArgumentException ex)
            //{
            //    _logger.Message($"Course {courseName} does not exists in the list");
            //    throw;
            //}
            //_logger.Message($"Course {courseName} does not exists in the list");
            //throw new ArgumentException($"Course '{courseName}' does not exist in the list");

        }

        public void PrintCourses()
        {
            if (Courses.Count == 0)
                Console.WriteLine("List is empty!");
            else
            {
                string str = "Courses: ";
                int n = 1;
                foreach (string c in Courses)
                {
                    str += c;
                    if (n != Courses.Count)
                        str += ", ";
                    n++;
                }
                Console.WriteLine(str);
            }
        }

    }
}
