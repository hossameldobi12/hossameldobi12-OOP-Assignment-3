using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public static class CourseStore
    {
        public static List<Course> Courses { get; set; } = new List<Course>();
        public static void AddCourse(Course course)
        {
            Courses.Add(course);
        }
        public static void RemoveCourse(Course course)
        {
            Courses.Remove(course);
        }
        public static Course? GetCourseById(int id)
        {
            return Courses.Find(c => c.Id == id);
        }
        public static List<Course> GetAllCourses()
        {
            return Courses;
        }
    }
}
