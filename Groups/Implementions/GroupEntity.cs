using Groups.Implementions;

namespace Groups.Implementions;

public class GroupEntity
{
    public string GroupId { get; set; }
    public string GroupName { get; set; }
    public List<StudentEntity> Students { get; set; }

    public GroupEntity(string groupId, string groupName)
    {
        GroupId = groupId;
        GroupName = groupName;
        Students = new List<StudentEntity>();
    }

    public void AddStudent(StudentEntity student)
    {
        Students.Add(student);
    }

    public override string ToString()
    {
        return $"Group: {GroupName}, ID: {GroupId}, Students Count: {Students.Count}";
    }
}
