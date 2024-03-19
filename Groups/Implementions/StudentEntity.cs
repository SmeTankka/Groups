namespace Groups.Implementions;

public class StudentEntity : PersonEntity
{
    public string StudentId { get; set; }
    public string Group { get; set; }

    public StudentEntity(int id, string firstName, string lastName, int age, string studentId, string group)
        : base(id, firstName, lastName, age)
    {
        StudentId = studentId;
        Group = group;
    }

    public override string ToString()
    {
        return base.ToString() + $", Student ID: {StudentId}, Group: {Group}";
    }
}
