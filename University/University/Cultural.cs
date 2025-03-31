using System.Globalization;
namespace University;

public class Cultural
{
    public void GetDateAndTime(string countryCode1, string countryCode2)
    {
        DateTime now = DateTime.Now;
        
        CultureInfo culture1 = new CultureInfo(countryCode1);
        CultureInfo culture2 = new CultureInfo(countryCode2);
        
        Console.WriteLine("Date formats for country1:");
        Console.WriteLine(now.ToString("yyyy-M-d dddd", culture1)); 
        Console.WriteLine(now.ToString("g", culture1));
        Console.WriteLine(now.ToString("D", culture1)); 
        Console.WriteLine(now.ToString("MM/dd/yyyy", culture1));

        Console.WriteLine("Date formats for country2:");
        Console.WriteLine(now.ToString("D", culture2)); 
        Console.WriteLine(now.ToString("g", culture2)); 
        Console.WriteLine(now.ToString("yyyy-M-d dddd", culture2)); 
        Console.WriteLine(now.ToString("MM/dd/yyyy", culture2));
    }
}