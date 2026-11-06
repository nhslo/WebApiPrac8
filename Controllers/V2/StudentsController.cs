using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using StudentApi.DTOs;
using StudentApi.Models;
using StudentApi.Services;
namespace StudentApi.Controllers.V2;
[ApiController]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/students")]
[Route("api/students")]
public class StudentsController : ControllerBase
{
    private readonly StudentService service;
    public StudentsController(StudentService service)
    {
        this.service = service;
    }
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(service.Students.Select(ToDto));
    }
    [HttpGet("{id:int}")]
    public IActionResult GetById(int id)
    {
        var student = service.Students.FirstOrDefault(studentItem => studentItem.Id == id);
        if (student == null)
        {
            return NotFound();
        }
        return Ok(ToDto(student));
    }
    private static StudentV2Dto ToDto(Student studentItem) => new()
    {
        Id = studentItem.Id, FirstName = studentItem.FirstName, LastName = studentItem.LastName,
        Group = studentItem.Group, GPA = studentItem.GPA, IsActive = studentItem.IsActive
    };
}
