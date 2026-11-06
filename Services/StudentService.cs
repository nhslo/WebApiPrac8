using StudentApi.Models;
namespace StudentApi.Services;
public class StudentService
{
    public List<Student> Students { get; } = new()
    {
        new() { Id = 1, FirstName = "Ivan", LastName = "Petrov", Group = "CS-301", GPA = 3.7, IsActive = true },
        new() { Id = 2, FirstName = "Anna", LastName = "Sidorova", Group = "CS-301", GPA = 3.9, IsActive = true },
        new() { Id = 3, FirstName = "Maria", LastName = "Kim", Group = "CS-302", GPA = 3.5, IsActive = true },
        new() { Id = 4, FirstName = "Daniyar", LastName = "Khan", Group = "CS-302", GPA = 3.1, IsActive = true },
        new() { Id = 5, FirstName = "Sergey", LastName = "Ivanov", Group = "CS-303", GPA = 2.8, IsActive = false }
    };
}
