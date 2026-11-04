using ClassLibrary;
using System;

List<Student> studentData = new()
{
    new Student { Id = 1, Name = "Ahmed" },
    new Student { Id = 2, Name = "Ali" },
    new Student { Id = 3, Name = "Omar" },
    new Student { Id = 4, Name = "Mona" },
    new Student { Id = 5, Name = "Sara" }
};

List<Course> courseData = new()
{
    new Course { Id = 101, Title = "C#", Price = 1000 },
    new Course { Id = 102, Title = "SQL", Price = 800 },
    new Course { Id = 103, Title = "ASP.NET Core", Price = 1500 }
};

// 1. Create stores
Store<Student> studentStore = new();
Store<Course> courseStore = new();

// 2. Add students
foreach (Student student in studentData)
{
    studentStore.Add(student);
}

// 3. Add courses
foreach (Course course in courseData)
{
    courseStore.Add(course);
}

// 4. Get one student and one course by id
Student? foundStudent = studentStore.GetById(3);
Course? foundCourse = courseStore.GetById(102);

Console.WriteLine("=== Get By Id ===");
Console.WriteLine(foundStudent?.Name);
Console.WriteLine(foundCourse?.Title);

// 5. Try adding a duplicate student
Console.WriteLine("\n=== Duplicate Id ===");

try
{
    studentStore.Add(new Student { Id = 3, Name = "New Student" });
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

// 6. Print page 2 (size 2)
Console.WriteLine("\n=== Page 2 ===");

foreach (Student student in studentStore.GetAll().Page(2, 2))
{
    Console.WriteLine($"{student.Id}: {student.Name}");
}

// 7. FindById on a plain List<Course>
Console.WriteLine("\n=== Find Course By Id ===");

Course? found = courseData.FindById(103);

Console.WriteLine(found?.Title);

// 8. This must NOT compile
// Store<string> stringStore = new();