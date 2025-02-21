using System.Net;

namespace University
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEvaluator evaluator = new Evaluator(); 
            var commmem = new CommitteeMember(evaluator, "Joshua","High Manager" );
            ResearchProject1 reproj = new ResearchProject1();
            reproj.Label = "Label of project";
            Console.WriteLine(commmem.GiveFeedback(reproj));

            /*var project = new ResearchProject("Project1", "Anna", new DateTime(2025, 1, 25), 30000);
            project.AddExpense(25000);

            Address address1 = new Address("Ukraine", "Zhytomyr", "Mykhailivska", "25");
            Address address2 = new Address("Ukraine", "Kyiv", "Zhytomyrska", "4");
            Address address3 = new Address("Ukraine", "Kyiv", "Chreschatyk", "36");
            var student1 = new Student(2345678, "Nina", 18, 82.7f, address1);
            var student2 = new Student(8465312, "Vanya", 20, 87f, address2);
            var student3 = new Student(7389569, "Misha", 26, 89.5f);

            student1.ShowInformation();
            student2.ShowInformation();
            student3.ShowInformation();
            Console.WriteLine($"Student count: {Student.Counter}"); */



        }
    }
}
