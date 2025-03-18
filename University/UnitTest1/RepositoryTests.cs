using University;

namespace UnitTest1;

public class RepositoryTests
{
    [Fact]
    public void DeletingItem()
    {
        
        List<Course> courses = new List<Course>();
        List<Course> coursesGetAll = new List<Course>();
        IRepository<Course> repo = new Repository<Course>(courses);
        Teacher uniTeacher = new Teacher();
        Course course1 = new Course("Discrete Math", uniTeacher, "Spring" );
        
            
        repo.Add(course1);
        repo.Delete(course1);
        Assert.Empty(repo.GetAll());


    }
    
    [Fact]
    public void AddingItem()
    {
        
        List<Course> courses = new List<Course>();
        List<Course> coursesGetAll = new List<Course>();
        IRepository<Course> repo = new Repository<Course>(courses);
        Teacher uniTeacher = new Teacher();
        Course course1 = new Course("Discrete Math", uniTeacher, "Spring" );
        Course course2 = new Course("Intro to OOP", uniTeacher, "Spring" );
        Course course3 = new Course("Algorithms", uniTeacher, "Summer" );
            
        repo.Add(course1);
        repo.Add(course2);
        
        Assert.Contains(course2, repo.GetAll());


    }
}