using University;
using Moq;
using Xunit;
namespace UnitTest1;


public class ComitteeTests
{
   [Fact]

   public void GradingProj()
   {
      var mockIEvaluator = new Mock<IEvaluator>();
      var commiteemem = new CommitteeMember(mockIEvaluator.Object,"Mark Levytskyi", "Senior Evaluation Manager");
      var proj = new ResearchProject1();
      proj.Field = "Medical Diagnostic";
      proj.Label = "Creating new type of MRT";
      string result = commiteemem.GradeProj(proj, 98);
      Assert.Equal("Creating new type of MRT received 98 grade", result);
   }

   [Fact]

   public void GivingFeedbackForProj()
   {
      var mockIEvaluator = new Mock<IEvaluator>();
      var commiteemem = new CommitteeMember(mockIEvaluator.Object,"Mark Levytskyi", "Senior Evaluation Manager");
      var proj = new ResearchProject1();
      proj.Field = "Medical Diagnostic";
      proj.Label = "Creating new type of MRT";
      string result = commiteemem.GiveFeedback(proj);
      Assert.Equal("Feedback for Creating new type of MRT", result);
   }
}