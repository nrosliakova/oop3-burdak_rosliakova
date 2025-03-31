using University;

namespace ResearchProjectTests
{
    public class ResearchProjectTests
    {
        [Fact]
        public void Test1()
        {
            Address address = new Address("Ukraine", "Zhytomyr", "Mykhailivska", "25");
            var student = new Student(2345678, "Nina", 18, 82.7f, address);
            student.ShowInformation();
            Assert.Equal(2345678, student.Id);
            Assert.Equal("Nina", student.Name);
        }

        [Fact]

        public void Test2()
        {
            Address address1 = new Address("Ukraine", "Zhytomyr", "Mykhailivska", "25");

            var student1 = new Student(2345678, "Nina", 18, 82.7f, address1);
            var student2 = new Student(7389569, "Misha", 26, 89.5f);

            student1.ShowInformation();

            student2.ShowInformation();
            //Assert.Equal(student2.Address, false);

        }

        [Fact]
        public void AddExpenseTest()
        {
            var project = new ResearchProject("Project1", "Anna", new DateTime(2025, 1, 25), 30000);
            var fundingLeft = project.AddExpense(25000);
            Assert.Equal(5000, fundingLeft);

        }

        
    }
}