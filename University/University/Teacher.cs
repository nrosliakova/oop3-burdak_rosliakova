namespace University
{
    public class Teacher : Person, IGetInfo
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public List<string> Courses { get; set; }
        public List<string> Groups { get; set; }
        public List<ResearchProject1> ResearchProjects1 { get; set; }
        public virtual string Status => "General Teacher";
        private readonly ILogger _logger;
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
            Courses = new List<string>();
            Groups = new List<string>();
            ResearchProjects1 = new List<ResearchProject1>();



        }

        public Teacher( ILogger logger, string name) : base(name)
        {
            AmountOfTeachers++;
            Id = AmountOfTeachers;
            Courses = new List<string>();
            Groups = new List<string>();
            ResearchProjects1 = new List<ResearchProject1>();
            _logger = logger;


        }

        public Teacher(int id, ILogger logger, string name) : base(name)
        {
            AmountOfTeachers++;
            Id = id;
            Courses = new List<string>();
            Groups = new List<string>();
            ResearchProjects1 = new List<ResearchProject1>();
            _logger = logger;



        }

        public Teacher(int id, string email, ILogger logger, string name) : base(name)
        {
            AmountOfTeachers++;
            Id = id;
            Email = email;
            Courses = new List<string>();
            Groups = new List<string>();
            ResearchProjects1 = new List<ResearchProject1>();
            _logger = logger;

        }

        public void AddCourse(string courseName)
        {
            Courses.Add(courseName);
            _logger.Message($"{courseName} added to the {Name}'s courses list");

        }

        public void RemoveCourse(string courseName)
        {

            Courses.Remove(courseName);
            _logger.Message($"{courseName} deleted from the {Name}'s courses list");


        }

        public new void ShowInformation()
        {
            Console.WriteLine($"Name: {Name}\nStatus: {Status}\n Email: {Email}\n Courses:{Courses}");
        }

        public virtual void GetInformation()
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
        
        public virtual void GetInfoForOverride()
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
            _logger.Message($"{group_name} added to the {Name}'s groups list");
        }

        public void RemoveGroup(string group_name)
        {
            Groups.Remove(group_name);
            _logger.Message($"{group_name} deleted from the {Name}'s groups list");
        }

        ~Teacher()
        {
            Console.WriteLine($"Teacher {Name} was dismissed");
        }

    }

    public class TeacherAssistant : Teacher

    {

        public override string Status => "Teacher Assistant";

        public override void GetInfoForOverride()
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
            ResearchProject1 researchProj = new ResearchProject1();
            researchProj.Label = projectName;
            ResearchProjects1.Add(researchProj);
            
        }
        public void AddResearchProject(ResearchProject1 projectName)//overload
        {
            ResearchProjects1.Add(projectName);
        }

    }

}
