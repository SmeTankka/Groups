using Groups.Implementions;

namespace Students.Implementations;

public class TeacherEntity : PersonEntity
{
    public string Subject { get; set; }
    public int YearsOfExperience { get; set; }

    public TeacherEntity(int id, string firstName, string lastName, int age, string subject, int yearsOfExperience)
        : base(id, firstName, lastName, age)
    {
        Subject = subject;
        YearsOfExperience = yearsOfExperience;
    }

    public override string ToString()
    {
        return base.ToString() + $", Subject: {Subject}, Years of Experience: {YearsOfExperience}";
    }
}
