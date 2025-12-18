using System;
namespace StudentManagement2;
public class Program
{
    public static void Main()
    {
        Student student = new Student(1, "John", 20);
        Student student1 = new Student(2, "Wick", 20);
        Student student2 = new Student(1, "Anh", 20);
        student.Display();
        student1.Display();
        student2.Display();
    }
}