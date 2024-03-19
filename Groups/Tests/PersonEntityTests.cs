using NUnit.Framework;
using Students.Implementations;

[TestFixture]
public class PersonEntityTests
{
    [Test]
    public void Constructor_SetsPropertiesCorrectly()
    {
        // Arrange & Act
        var person = new PersonEntity(1, "John", "Doe", 30);

        // Assert
        Assert.AreEqual(1, person.Id);
        Assert.AreEqual("John", person.FirstName);
        Assert.AreEqual("Doe", person.LastName);
        Assert.AreEqual(30, person.Age);
    }
}

