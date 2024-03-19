using NUnit.Framework;
using Groups.Implementions;
using Students.Implementations; // Для доступу до TeacherEntity

[TestFixture]
public class SubjectEntityTests
{
    [Test]
    public void Constructor_InitializesPropertiesCorrectly()
    {
        // Arrange
        string subjectName = "Advanced Physics";
        var teacher = new TeacherEntity(2, "Emily", "Stone", 40, "Physics", 15);

        // Act
        var subject = new SubjectEntity(subjectName, teacher);

        // Assert
        Assert.AreEqual(subjectName, subject.SubjectName);
        Assert.AreSame(teacher, subject.Teacher);
    }

    [Test]
    public void ToString_ReturnsExpectedFormat()
    {
        // Arrange
        var teacher = new TeacherEntity(2, "Emily", "Stone", 40, "Physics", 15);
        var subject = new SubjectEntity("Advanced Physics", teacher);

        // Act
        var result = subject.ToString();

        // Assert
        Assert.AreEqual("Subject: Advanced Physics, Teacher: Emily Stone", result);
    }
}
