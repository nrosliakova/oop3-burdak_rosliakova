namespace University;

public interface IEvaluator
{
    public string Proj_feedback(ResearchProject1 research_proj);
    public string EvaluateProj(ResearchProject1 research_proj, int score);
}