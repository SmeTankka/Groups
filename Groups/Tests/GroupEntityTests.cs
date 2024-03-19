using NUnit.Framework;
using System.Linq;
using Students.Implementations;

[TestFixture]
public class GroupEntityTests
{
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
    }
}
