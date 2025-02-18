namespace University;
using System.Diagnostics;
using Microsoft.Extensions.Logging;


public class Logger : ILogger
{
    public Microsoft.Extensions.Logging.ILogger logger;

    public Logger(Microsoft.Extensions.Logging.ILogger logger)
    {
        this.logger = logger;
    }
    
    public void Message(string text)
    {
        Debug.WriteLine($"[LOG]: {text} ");
        this.logger.LogInformation(text);
    }
    
}