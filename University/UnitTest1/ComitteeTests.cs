using University;
using Moq;
namespace UnitTest1;


public class ComitteeTests
{
   [Fact]

   public void GradingProj()
   {
      var mockEvaluator = new Mock<IEvaluator>();
      mockEvaluator.Setup(e => e.EvaluateProj(It.IsAny<ResearchProject1>(), It.IsAny<int>())).Returns("Creating new type of MRT received 98 grade");      var commiteemem = new CommitteeMember(mockEvaluator.Object,"Mark Levytskyi", "Senior Evaluation Manager");
      var proj = new ResearchProject1();
      proj.Field = "Medical Diagnostic";
      proj.Label = "Creating new type of MRT";
      string result = commiteemem.GradeProj(proj, 98);
      Assert.Equal("Creating new type of MRT received 98 grade", result);
   }

   [Fact]

   public void GivingFeedbackForProj()
   {
      var mockEvaluator = new Mock<IEvaluator>();
      mockEvaluator.Setup(e => e.Proj_feedback(It.IsAny<ResearchProject1>())).Returns("Feedback for Creating new type of MRT");
      var commiteemem = new CommitteeMember(mockEvaluator.Object,"Mark Levytskyi", "Senior Evaluation Manager");
      var proj = new ResearchProject1();
      proj.Field = "Medical Diagnostic";
      proj.Label = "Creating new type of MRT";
      string result = commiteemem.GiveFeedback(proj);
      Assert.Equal("Feedback for Creating new type of MRT", result);
   }
   
   [Fact]
   public void TestingExceptionForResearchStruct()
   {
      var mockEvaluator = new Mock<IEvaluator>();
      mockEvaluator.Setup(e => e.Proj_feedback(It.IsAny<ResearchProject1>())).Returns("Проблемка: Немає назви, немає проєкту, придумайте і тоді пишіть!");
      var commiteemem = new CommitteeMember(mockEvaluator.Object,"Mark Levytskyi", "Senior Evaluation Manager");
      var proj = new ResearchProject1();
      Assert.Equal("Проблемка: Немає назви, немає проєкту, придумайте і тоді пишіть!", commiteemem.GiveFeedback(proj));
            
   }
   [Fact]
   public void TestingExceptionForEvaluatingProj()
   {
      var mockEvaluator = new Mock<IEvaluator>();
      mockEvaluator.Setup(e => e.EvaluateProj(It.IsAny<ResearchProject1>(), It.IsAny<int>())).Returns("Проблема: Оцінка не може бути від'ємною");
      var commiteemem = new CommitteeMember(mockEvaluator.Object,"Mark Levytskyi", "Senior Evaluation Manager");
      var proj = new ResearchProject1();
      proj.Field = "Medical Diagnostic";
      proj.Label = "Creating new type of MRT";
      Assert.Equal("Проблема: Оцінка не може бути від'ємною", commiteemem.GradeProj(proj, 52));
            
   }
}