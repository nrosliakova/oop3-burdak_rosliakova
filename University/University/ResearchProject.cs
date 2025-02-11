using System.Net;

namespace University
{
    public class ResearchProject
    {
        public string Title { get; }
        public string LeadResearcher { get; }
        public DateTime StartDate { get; }
        public float FundingAmount { get; set; }
        public float expenses = 0;


        public ResearchProject()
        {

        }

        public ResearchProject(string title, string researcher, DateTime startDate, float funding)
        {

            Title = title;
            LeadResearcher = researcher;
            StartDate = startDate;
            FundingAmount = funding;
        }


        public ResearchProject(string title, string researcher)
        {

            Title = title;
            LeadResearcher = researcher;
        }

        public float AddExpense(float newExpense)
        {
            if (FundingAmount >= expenses)
            {
                expenses += newExpense;
                FundingAmount -= expenses;
                Console.WriteLine($"new expense added, funding left: {FundingAmount}");
            }
            else
                Console.WriteLine($"new expense not added, not enough funding");

            return FundingAmount;
        }

    }

}
