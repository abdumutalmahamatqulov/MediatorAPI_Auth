using MediatorAPI_Auth.Models;
using MediatorAPI_Auth.Repositories;
using Microsoft.AspNetCore.Authorization;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using MediatorAPI_Auth.Commands.StudentCommand;
using MediatR;
using MediatorAPI_Auth.Queries.StudentQueries;

namespace MediatorAPI_Auth.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "ADMIN")]
public class StudentsController : ControllerBase
{
    private readonly IMediator _mediator;

    public StudentsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<List<Student>> GetStudentListAsync()
    {
        var studentdetails = await _mediator.Send(new GetStudentListQuery());
        return studentdetails;
    }

    [HttpGet("studentId")]
    [Authorize]
    public async Task<Student> GetStudentByIdAsync(int studentId)
    {
        var studentDetails = await _mediator.Send(new GetStudentByIdQuery() { Id = studentId });

        return studentDetails;
    }

    [HttpPost]
    [Authorize(Roles = "SUPERADMIN")]
    public async Task<Student> AddStudentAsync(Student studentDetails)
    {
        var studentDetail = await _mediator.Send(new CreateStudentCommand(
            studentDetails.StudentName,
            studentDetails.StudentEmail,
            studentDetails.StudentAddress,
            studentDetails.StudentAge));
        return studentDetail;
    }

    [HttpPut]
    public async Task<int> UpdateStudentAsync(Student studentDetails)
    {
        var isStudentDetailUpdated = await _mediator.Send(new UpdateStudentCommand(
            studentDetails.Id,
            studentDetails.StudentName,
            studentDetails.StudentEmail,
            studentDetails.StudentAddress,
            studentDetails.StudentAge));
        return isStudentDetailUpdated;
    }

    [HttpDelete]
    public async Task<int> DeleteStudentAsync(int Id)
    {
        return await _mediator.Send(new DeleteStudentCommand() { Id = Id });
    }
}
