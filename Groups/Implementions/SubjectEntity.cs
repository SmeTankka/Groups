namespace Groups.Implementions;

public class SubjectEntity
{
    public string SubjectName { get; set; }
    public TeacherEntity Teacher { get; set; }

    public SubjectEntity(string subjectName, TeacherEntity teacher)
    {
        SubjectName = subjectName;
        Teacher = teacher;
    }

    public override string ToString()
    {
        return $"Subject: {SubjectName}, Teacher: {Teacher.FirstName} {Teacher.LastName}";
    }
}
