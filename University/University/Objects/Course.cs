namespace University;

public class Course
{
    public string Name { get; }
    public Teacher Teacher { get; }
    public string Term { get; }

    public Course(string name, Teacher teacher, string term)
    {
        Name = name;
        Teacher = teacher;
        Term = term;
    }

    public void ShowInformation()
    {
        Console.WriteLine($"{Name} during {Term}, formed by {Teacher}");
    }
}