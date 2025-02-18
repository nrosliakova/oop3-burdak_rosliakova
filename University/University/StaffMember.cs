namespace University;

public abstract class StaffMember
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    

    public abstract void ShowResponsibilities();

    public void Working()
    {
        Console.WriteLine("I am working working, tu-du-du..");
    }
}

public class CleaningManager : StaffMember
{
    public override void ShowResponsibilities()
    {
        Console.WriteLine($"{Name} is responsible for cleaning A-wing changing bed linen in sleeping rooms every week");
    }
    
}