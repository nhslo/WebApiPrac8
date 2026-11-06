using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using StudentApi.DTOs;
using StudentApi.Services;
namespace StudentApi.Controllers.V1;
[ApiController]
[ApiVersion("1.0")]
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
    public IActionResult GetAll() => Ok(service.Students.Select(studentItem => new StudentV1Dto
    {
        Id = studentItem.Id, FullName = studentItem.FirstName + " " + studentItem.LastName
    }));
}
