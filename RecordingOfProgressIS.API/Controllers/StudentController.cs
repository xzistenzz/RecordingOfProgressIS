using MediatR;
using Microsoft.AspNetCore.Mvc;
using RecordingOfProgressIS.Application.CQRS.Students.Queries;
using RecordingOfProgressIS.Domain.Models;
using RecordingOfProgressIS.Infrastructure.Repositories.Interfaces;

namespace RecordingOfProgressIS.API.Controllers;


public class StudentController : Controller
{
    private IMediator _mediator;

    public StudentController(IMediator mediator, IRepository<Student> rep)
    {
        _mediator = mediator;
    }

    [HttpGet(nameof(GetStudent))]
    public async Task<IActionResult> GetStudent([FromQuery] int studentId)
    {
        var response = await _mediator.Send(new GetStudentByIdQuery(studentId));
        return Ok(response);
    }
}