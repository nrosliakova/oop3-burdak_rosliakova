using NUnit.Framework;
using University;

namespace TeacherTests
{
    [TestFixture]
    public sealed class TeacherTests
    {

        private Teacher teacher;

        [SetUp]
        public void Setup()
        {
            teacher = new Teacher(1, "Unit Richard", "unitrichard@gmail.com", "lector");
        }

        [Test]
        public void AddingGroup_to_Teacher()
        {
            teacher.AddGroup("Group1");
            Assert.IsTrue(teacher.Groups.Contains("Group1"), "Group was not added");
        }
        [Test]
        public void AddingCourse_to_Teacher()
        {
            teacher.AddCourse("Course1");
            Assert.IsTrue(teacher.Courses.Contains("Course1"), "Course was not added");
        }

        [Test]
        public void Changing_Teacher_Status()
        {
            teacher.ChangeStatus("teacher assistant");
            Assert.AreEqual("teacher assistant", teacher.Status, "Status has not changed");
        }
    }
}