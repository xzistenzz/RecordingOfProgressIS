using MediatR;
using Microsoft.AspNetCore.Mvc;
using RecordingOfProgressIS.Application.CQRS.Students.Commands;
using RecordingOfProgressIS.Application.CQRS.Students.Queries;
using RecordingOfProgressIS.ApplicationContract.Requests;
using RecordingOfProgressIS.Domain.Models;
using RecordingOfProgressIS.Infrastructure.Repositories.Interfaces;

namespace RecordingOfProgressIS.API.Controllers;


public class StudentController : Controller
{
    private IMediator _mediator;

    public StudentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet(nameof(GetStudent))]
    public async Task<IActionResult> GetStudent([FromQuery] int studentId)
    {
        var response = await _mediator.Send(new GetStudentByIdQuery(studentId));
        return Ok(response);
    }

    [HttpPost(nameof(CreateStudent))]
    public async Task<IActionResult> CreateStudent([FromBody] CreateStudentRequest request)
    {
        var response = await _mediator.Send(new CreateStudenCommand(request));
        return Ok(response);
    }
}