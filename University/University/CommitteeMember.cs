namespace University;

public class CommitteeMember:ICommitteeMember
{
    public string Name;
    public string Position;
    private readonly IEvaluator _evaluator;

    public CommitteeMember(IEvaluator evaluator, string name, string position)
    {
        _evaluator = evaluator;
        Position = position;
        Name = name;
    }

    public string GiveFeedback(ResearchProject1 researchProj)
    {
        return _evaluator.Proj_feedback(researchProj);
    }

    public string GradeProj(ResearchProject1 researchProj, int score)
    {
        return _evaluator.EvaluateProj(researchProj, score);
    }
}