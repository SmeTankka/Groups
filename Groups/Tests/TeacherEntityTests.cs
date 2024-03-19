using NUnit.Framework;
using Students.Implementations;


[TestFixture]
public class TeacherEntityTests
{
    [Test]
    public void Constructor_SetsTeacherSpecificPropertiesCorrectly()
    {
        // Arrange & Act
        var teacher = new TeacherEntity(2, "Jane", "Doe", 35, "Math", 10);

        // Assert
        Assert.AreEqual("Math", teacher.Subject);
        Assert.AreEqual(10, teacher.YearsOfExperience);
    }
}

