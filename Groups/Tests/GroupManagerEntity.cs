using NUnit.Framework;
using Groups.Implementations; 
[TestFixture]
public class GroupManagerEntityTests
{
    [Test]
    public void AddGroup_AddsGroupToManager()
    {
        // Arrange
        var manager = new GroupManagerEntity();
        var group = new GroupEntity("G1", "Test Group");

        // Act
        manager.AddGroup(group);

        // Assert
        Assert.AreEqual(1, manager.Groups.Count);
        Assert.Contains(group, manager.Groups);
    }

    [Test]
    public void FindGroupById_ReturnsCorrectGroup()
    {
        // Arrange
        var manager = new GroupManagerEntity();
        var group = new GroupEntity("G1", "Test Group");
        manager.AddGroup(group);

        // Act
        var result = manager.FindGroupById("G1");

        // Assert
        Assert.AreEqual(group, result);
    }

    [Test]
    public void FindGroupById_ReturnsNullIfNotFound()
    {
        // Arrange
        var manager = new GroupManagerEntity();

        // Act
        var result = manager.FindGroupById("G1");

        // Assert
        Assert.IsNull(result);
    }

    [Test]
    public void RemoveGroup_RemovesGroupCorrectly()
    {
        // Arrange
        var manager = new GroupManagerEntity();
        var group = new GroupEntity("G1", "Test Group");
        manager.AddGroup(group);

        // Act
        var result = manager.RemoveGroup("G1");

        // Assert
        Assert.IsTrue(result);
        Assert.AreEqual(0, manager.Groups.Count);
    }

    [Test]
    public void RemoveGroup_ReturnsFalseIfGroupNotFound()
    {
        // Arrange
        var manager = new GroupManagerEntity();

        // Act
        var result = manager.RemoveGroup("G1");

        // Assert
        Assert.IsFalse(result);
        Assert.AreEqual(0, manager.Groups.Count);
    }
}
