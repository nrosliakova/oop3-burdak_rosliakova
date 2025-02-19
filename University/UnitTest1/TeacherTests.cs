using Microsoft.VisualStudio.TestPlatform.Common.Exceptions;
using Xunit;
using University;
using Moq;

namespace TeacherTests
{
    
    public class TeacherTests
    {
        [Fact]
        public void AddingGroup_to_Teacher()
        {   var mockLogger = new Mock<ILogger>();
            var teacher = new Teacher(1, "unitrichard@gmail.com", mockLogger.Object ,"Unit Richard");
            teacher.AddGroup("Group1");
            bool result = teacher.Groups.Contains("Group1");
            Assert.True(result);
            mockLogger.Verify(logger => logger.Message(It.Is<string>(msg => msg.Contains("Group1"))), Times.Once);
        }
        
        [Fact]
        public void AddingCourse_to_Teacher()
        {   var mockLogger = new Mock<ILogger>();
            var teacher = new Teacher(1, "unitrichard@gmail.com", mockLogger.Object ,"Unit Richard");
            teacher.AddCourse("Course1", "1 term" );
            Assert.Equal("Course1", teacher.Courses[teacher.Courses.Count -1].Name);
            mockLogger.Verify(logger => logger.Message(It.Is<string>(msg => msg.Contains("Course1"))), Times.Once);
        }
        

        [Fact]
        public void ShowingInfoWithHidingMethod()
        {
            var mockLogger = new Mock<ILogger>();
            var teacher = new Teacher(1, "unitrichard@gmail.com", mockLogger.Object ,"Unit Richard");
            string result = teacher.ShowInformation();
            Assert.Equal("Name: Unit Richard\nStatus: lector\n Email: unitrichard@gmail.com\n Courses:", result);
        }

        [Fact]

        public void OverrideMethodGetInfo()
        {
            var mockLogger = new Mock<ILogger>();
            var teachassistant = new TeacherAssistant();
            string result = teachassistant.GetInfoForOverride();
            int id = teachassistant.Id;
            Assert.Equal($"Unknown is a Teacher Assistant with {id} id on these courses: ", result);

        }
    }
    
}