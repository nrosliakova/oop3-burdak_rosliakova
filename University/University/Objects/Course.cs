namespace University;

public class Course:HasId
{
    public int Id { get; set; }
    public string Name { get; }
    public Teacher Teacher { get; }
    public string Term { get; }
    public static int AmountOfCourses = 0;
    public Course(string name, Teacher teacher, string term)
    {
        AmountOfCourses++;
        Id = AmountOfCourses;
        Name = name;
        Teacher = teacher;
        Term = term;
        
    }

    public void ShowInformation()
    {
        Console.WriteLine($"{Name} during {Term}, formed by {Teacher}");
    }
}