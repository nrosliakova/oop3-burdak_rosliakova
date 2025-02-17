namespace University
{
    public class Teacher : Person
    {
        public int Id { get; set; }
        //public string Name { get; set; }
        public string Email { get; set; }
        public List<string> Courses { get; set; }
        public List<string> Groups { get; set; }
        public List<ResearchProject> ResearchProjects { get; set; }
        public virtual string Status => "General Teacher";
        private readonly CourseService _cService;
        private int salary;

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    salary = value;
                else
                {
                    Console.WriteLine("Salary cannot be in minus");
                }
            }
        }

        public static int AmountOfTeachers = 0;

        public Teacher()
        {
            AmountOfTeachers++;
            Id = AmountOfTeachers;
            //Name = "Unknown";
            Courses = new List<string>();
            Groups = new List<string>();
            ResearchProjects = new List<ResearchProject>();



        }

        //public Teacher(int id, CourseService cService)
        //{
        //    AmountOfTeachers++;
        //    Id = AmountOfTeachers;
        //    Name = "Unknown";
        //    Courses = new List<string>();
        //    Groups = new List<string>();
        //    ResearchProjects = new List<ResearchProject>();
        //    _cService = cService;


        //}

        public Teacher(int id, string name, CourseService cService)
            : base(name)
        {
            AmountOfTeachers++;
            Id = id;
            //Name = name;
            Courses = new List<string>();
            Groups = new List<string>();
            ResearchProjects = new List<ResearchProject>();
            _cService = cService;



        }

        public Teacher(int id, string name, string email, CourseService cService)
            : base(name)
        {
            AmountOfTeachers++;
            Id = id;
            //Name = name;
            Email = email;
            Courses = new List<string>();
            Groups = new List<string>();
            ResearchProjects = new List<ResearchProject>();
            _cService = cService;

        }

        public void AddCourse(string courseName)
        {
            Courses.Add(courseName);
            _cService.AddCourse(courseName);

        }

        public void RemoveCourse(string courseName)
        {

            Courses.Remove(courseName);
            _cService.RemoveCourse(courseName);


        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"{Name} is a GeneralTeacher with {Id} id on these courses: ");
            if (Courses.Count != 0)
            {
                Console.WriteLine("General Teacher has no course");
            }
            else
            {
                foreach (var course in Courses)
                {
                    Console.WriteLine(course);
                }
            }

        }

        public void GetAmountCourses_CustomForHiding()
        {
            Console.WriteLine($"{Name} text for hiding");
        }

        public void AddGroup(string group_name)
        {
            Groups.Add(group_name);
            Console.WriteLine($"{group_name} course added");
        }

        public void RemoveGroup(string group_name)
        {
            Groups.Remove(group_name);
            Console.WriteLine($"{group_name} group removed");
        }

        ~Teacher()
        {
            Console.WriteLine($"Teacher {Name} was dismissed");
        }

    }

    public class TeacherAssistant : Teacher

    {

        public override string Status => "Teacher Assistant";

        public override void GetInfo()
        {
            Console.WriteLine($"{Name} is a Teacher Assistant with {Id} id on these courses: ");
            if (Courses.Count != 0)
            {
                Console.WriteLine("Teacher Assistant has no course");
            }
            else
            {
                foreach (var course in Courses)
                {
                    Console.WriteLine(course);
                }
            }
        }
        public new void GetAmountCourses_CustomForHiding()
        {
            if (Courses.Count != 0)
            {
                Console.WriteLine($"{Name} has no course");

            }
            else
            {
                Console.WriteLine($"{Name}'s courses:");
                foreach (var course in Courses)
                {
                    Console.WriteLine(course);
                }
            }
        }

        public void AddResearchProject()//overload
        {
            Console.WriteLine("There is no research project in arguments");
        }

        public void AddResearchProject(string projectName)//overload
        {
            ResearchProject researchProj = new ResearchProject();
            researchProj.label = projectName;
        }
        public void AddResearchProject(ResearchProject projectName)//overload
        {
            ResearchProjects.Add(projectName);
        }

    }

}
