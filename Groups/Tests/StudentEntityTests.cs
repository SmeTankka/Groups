using NUnit.Framework;
using Students.Implementations;

[TestFixture]
public class StudentEntityTests
{
    [Test]
    public void Constructor_SetsStudentSpecificPropertiesCorrectly()
    {
        // Arrange & Act
        var student = new StudentEntity(1, "John", "Doe", 20, "S123", "CS101");

        // Assert
        Assert.AreEqual("S123", student.StudentId);
        Assert.AreEqual("CS101", student.Group);
    }
}

