namespace University;

public class Evaluator:IEvaluator
{
    public string Proj_feedback(ResearchProject1 research_proj)
    {
        return $"Feedback for {research_proj.Label}";
    }

    public string EvaluateProj(ResearchProject1 research_proj, int score)
    {
        return $"{research_proj.Label} received {score} grade";  
    }
}