using NUnit.Framework;
using Groups.Implementations; 
using Students.Implementations; 

[TestFixture]
public class GroupEntityTests
{
    [Test]
    public void Constructor_InitializesPropertiesCorrectly()
    {
        // Arrange & Act
        var group = new GroupEntity("G1", "Test Group");

        // Assert
        Assert.AreEqual("G1", group.GroupId);
        Assert.AreEqual("Test Group", group.GroupName);
        Assert.IsNotNull(group.Students);
        Assert.IsEmpty(group.Students);
    }

    [Test]
    public void AddStudent_AddsStudentToGroup()
    {
        // Arrange
        var group = new GroupEntity("G1", "Test Group");
        var student = new StudentEntity(1, "John", "Doe", 20, "S123", "CS101");

        // Act
        group.AddStudent(student);

        // Assert
        Assert.IsTrue(group.Students.Contains(student));
        Assert.AreEqual(1, group.Students.Count);
    }

    [Test]
    public void ToString_ReturnsCorrectFormat()
    {
        // Arrange
        var group = new GroupEntity("G1", "Test Group");

        // Act
        var result = group.ToString();

        // Assert
        StringAssert.AreEqualIgnoringCase("Group: Test Group, ID: G1, Students Count: 0", result);
    }
}
