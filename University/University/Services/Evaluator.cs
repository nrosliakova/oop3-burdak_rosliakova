namespace University;

public class Evaluator:IEvaluator
{
    public string Proj_feedback(ResearchProject1 research_proj)
    {
        try
        {
            if (research_proj.Label == null)
            {
                throw new Exception("Немає назви, немає проєкту, придумайте і тоді пишіть!");
            }

            return $"Feedback for {research_proj.Label}";

        }
        catch (Exception e)
        {
            Console.WriteLine($"Проблемка: {e.Message}"); //логування
            return $"Проблемка: {e.Message}";
            
        }
        finally
        {
            Console.WriteLine("Помилка оброблена");
        }
        
    }

    public string EvaluateProj(ResearchProject1 research_proj, int score)
    {
        try
        {
            if (score < 0)
            {
                throw new ArgumentException("Оцінка не може бути від'ємною");
            }

            return $"{research_proj.Label} received {score} grade";
        }
        catch (Exception e)
        {
            Console.WriteLine($"Проблема: {e.Message}");
            throw;

        }
        finally
        {
            Console.WriteLine("Опрацювання проблеми завершене");
        }
         
        
        
    }
}