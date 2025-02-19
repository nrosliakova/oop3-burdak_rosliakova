namespace University;

public abstract class StaffMember
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    

    public abstract string ShowResponsibilities();

    public string Working()
    {
        return "I am working working, tu-du-du..";
    }
}

public class CleaningManager : StaffMember
{
    public override string ShowResponsibilities()
    {
        return $"{Name} is responsible for cleaning A-wing changing bed linen in sleeping rooms every week";
    }
    
}