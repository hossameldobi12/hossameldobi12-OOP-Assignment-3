using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public static class StudentStore
    {
        public static List<Student> Students { get; set; } = new List<Student>();

        public static void AddStudent(Student student)
        {
            Students.Add(student);
        }
        public static void RemoveStudent(Student student)
        {
            Students.Remove(student);
        }
        public static Student? GetStudentById(int id)
        {
            return Students.Find(s => s.Id == id);
        }
        public static List<Student> GetAllStudents()
        {
            return Students;
        }
    }
}
