using NUnit.Framework;
using Students.Implementations;

[TestFixture]
public class TeacherEntityTests
{
    [Test]
    public void Constructor_InitializesPropertiesCorrectly()
    {
        // Arrange
        int id = 2;
        string firstName = "Emily";
        string lastName = "Stone";
        int age = 40;
        string subject = "Physics";
        int yearsOfExperience = 15;

        // Act
        var teacher = new TeacherEntity(id, firstName, lastName, age, subject, yearsOfExperience);

        // Assert
        Assert.AreEqual(id, teacher.Id);
        Assert.AreEqual(firstName, teacher.FirstName);
        Assert.AreEqual(lastName, teacher.LastName);
        Assert.AreEqual(age, teacher.Age);
        Assert.AreEqual(subject, teacher.Subject);
        Assert.AreEqual(yearsOfExperience, teacher.YearsOfExperience);
    }

    [Test]
    public void ToString_ReturnsExpectedFormat()
    {
        // Arrange
        var teacher = new TeacherEntity(2, "Emily", "Stone", 40, "Physics", 15);

        // Act
        var result = teacher.ToString();

        // Assert
        Assert.AreEqual("Emily Stone, Age: 40, Subject: Physics, Years of Experience: 15", result);
    }
}
