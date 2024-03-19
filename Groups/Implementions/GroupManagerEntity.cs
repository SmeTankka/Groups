using Students.Implementations;

namespace Groups.Implementions;

public class GroupManagerEntity
{
    private List<GroupEntity> groups;

    public GroupManagerEntity()
    {
        groups = new List<GroupEntity>();
    }

    public void AddGroup(GroupEntity group)
    {
        groups.Add(group);
    }

    public GroupEntity FindGroupById(string groupId)
    {
        return groups.FirstOrDefault(g => g.GroupId == groupId);
    }

    public bool RemoveGroup(string groupId)
    {
        var group = FindGroupById(groupId);
        if (group != null)
        {
            groups.Remove(group);
            return true;
        }
        return false;
    }
}
