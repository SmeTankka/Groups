using System;
using Students.Implementations; 

class Program
{
    static void Main(string[] args)
    {
        // Створення вчителя
        var teacher = new TeacherEntity(1, "Emma", "Watson", 35, "Computer Science", 10);

        // Створення студентів
        var student1 = new StudentEntity(2, "John", "Doe", 20, "S123", "CS101");
        var student2 = new StudentEntity(3, "Jane", "Doe", 19, "S124", "CS101");

        // Створення предмета
        var subject = new SubjectEntity("Programming 101", teacher);

        // Створення групи і додавання студентів
        var group = new GroupEntity("CS101", "Computer Science 101");
        group.AddStudent(student1);
        group.AddStudent(student2);

        // Виведення інформації про групу
        Console.WriteLine($"Group: {group.GroupName}");
        foreach (var student in group.Students)
        {
            Console.WriteLine($"Student: {student.FirstName} {student.LastName}, ID: {student.StudentId}");
        }

        // Виведення інформації про предмет
        Console.WriteLine($"Subject: {subject.SubjectName}, Teacher: {subject.Teacher.FirstName} {subject.Teacher.LastName}");
    }
}
