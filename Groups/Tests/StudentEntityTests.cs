using NUnit.Framework;
using Groups.Implementations;

[TestFixture]
public class StudentEntityTests
{
    [Test]
    public void Constructor_InitializesPropertiesCorrectly()
    {
        // Arrange
        int id = 1;
        string firstName = "John";
        string lastName = "Doe";
        int age = 20;
        string studentId = "S123";
        string group = "CS101";

        // Act
        var student = new StudentEntity(id, firstName, lastName, age, studentId, group);

        // Assert
        Assert.AreEqual(id, student.Id);
        Assert.AreEqual(firstName, student.FirstName);
        Assert.AreEqual(lastName, student.LastName);
        Assert.AreEqual(age, student.Age);
        Assert.AreEqual(studentId, student.StudentId);
        Assert.AreEqual(group, student.Group);
    }

    [Test]
    public void ToString_ReturnsExpectedFormat()
    {
        // Arrange
        var student = new StudentEntity(1, "John", "Doe", 20, "S123", "CS101");

        // Act
        var result = student.ToString();

        // Assert
        Assert.AreEqual("John Doe, Age: 20, Student ID: S123, Group: CS101", result);
    }
}