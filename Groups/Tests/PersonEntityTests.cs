using NUnit.Framework;
using Groups.Implementations;

[TestFixture]
public class PersonEntityTests
{
    [Test]
    public void Constructor_InitializesPropertiesCorrectly()
    {
        // Arrange
        int id = 1;
        string firstName = "John";
        string lastName = "Doe";
        int age = 30;

        // Act
        var person = new PersonEntity(id, firstName, lastName, age);

        // Assert
        Assert.AreEqual(id, person.Id);
        Assert.AreEqual(firstName, person.FirstName);
        Assert.AreEqual(lastName, person.LastName);
        Assert.AreEqual(age, person.Age);
    }

    [Test]
    public void ToString_ReturnsExpectedFormat()
    {
        // Arrange
        var person = new PersonEntity(1, "John", "Doe", 30);

        // Act
        var result = person.ToString();

        // Assert
        Assert.AreEqual("John Doe, Age: 30", result);
    }
}
