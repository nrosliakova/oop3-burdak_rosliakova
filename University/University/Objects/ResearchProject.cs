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
        private readonly ILogger _logger;

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
            try
            {
                if (FundingAmount >= expenses)
                {
                    expenses += newExpense;
                    FundingAmount -= expenses;
                    Console.WriteLine($"new expense added, funding left: {FundingAmount}");
                }
                else
                {
                    //Console.WriteLine($"new expense not added, not enough funding");
                    _logger.Message("new expense not added, not enough funding");
                    //throw new Exception("Not enough funding");
                    throw new InsufficientFundsException("Not enough funding");
                }
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Insufficient Funds: {ex.Message}");
                throw ex;
            }
            return FundingAmount;
        }

    }

}
