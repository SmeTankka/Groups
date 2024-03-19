using NUnit.Framework;
using Students.Implementations;

namespace Students.Tests
{
    [TestFixture]
    public class SubjectEntityTests
    {
        [Test]
        public void Constructor_SetsSubjectPropertiesCorrectly()
        {
            // Arrange
            var teacher = new TeacherEntity(3, "Emily", "Stone", 40, "Physics", 15);
            var subject = new SubjectEntity("Physics 101", teacher);

            // Act & Assert
            Assert.AreEqual("Physics 101", subject.SubjectName);
            Assert.AreSame(teacher, subject.Teacher);
        }
    }
}
