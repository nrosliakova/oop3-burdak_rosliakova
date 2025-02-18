using Microsoft.VisualStudio.TestPlatform.Common.Exceptions;
using XUnit.Framework;
using University;

namespace TeacherTests
{
    
    public class TeacherTests
    {
        [Fact]
        public void AddingGroup_to_Teacher()
        {   var teacher = new Teacher(1, "Unit Richard", "unitrichard@gmail.com", "lector");
            teacher.AddGroup("Group1");
            bool result = teacher.Groups.Contains("Group1");
            Assert.True(result);
        }
        
        [Fact]
        public void AddingCourse_to_Teacher()
        {
            var teacher = new Teacher(1, "Unit Richard", "unitrichard@gmail.com", "lector");
            teacher.AddCourse("Course1");
            bool result = teacher.Groups.Contains("Course1");
            Assert.True(result);
        }

        [Fact]
        public void Changing_Teacher_Status()
        {
            var teacher = new Teacher(1, "Unit Richard", "unitrichard@gmail.com", "lector");
            teacher.ChangeStatus("teacher assistant");
            string status = teacher.Status;
            Assert.Equal("teacher assistant", status);
        }

        [Fact]
        public void ShowingInfoWithHidingMethod()
        {
            var teacher = new Teacher(1, "Unit Richard", "unitrichard@gmail.com", "lector");
            string result = teacher.ShowInformation();
            Assert.Equal("Name: Unit Richard\nStatus: lector\n Email: unitrichard@gmail.com\n Courses:", result);
        }

        [Fact]

        public void OverrideMethodGetInfo()
        {
            var teachassistant = new TeachAssis();
            string result = teachassistant.GetInfoForOverride();
            int id = teachassistant.Id;
            Assert.Equal($"Unknown is a Teacher Assistant with {id} id on these courses: ", result);

        }
    }
    
}