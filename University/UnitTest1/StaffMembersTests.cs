namespace StaffTests
{
    public class StaffMembersTests
    {
        [Fact]
        public void TestingMethods1()
        {
            var cleanManager = new CleaningManager();
            cleanManager.Id = 1;
            cleanManager.Name = "John";
            cleanManager.Position = "Cleaning Manager of 3 level";

            string working = cleanManager.Working();
            Assert.Equal("I am working working, tu-du-du..", working);

        }
        
        public void TestingMethods2()
        {
            var cleanManager = new CleaningManager();
            cleanManager.Id = 1;
            cleanManager.Name = "John";
            cleanManager.Position = "Cleaning Manager of 3 level";

            string responsibilities = cleanManager.ShowResponsibilities();
            Assert.Equal("John is responsible for cleaning A-wing changing bed linen in sleeping rooms every week", responsibilities);

        }
    }
}
