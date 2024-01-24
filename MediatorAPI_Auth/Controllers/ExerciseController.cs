using MediatorAPI_Auth.Models;
using MediatorAPI_Auth.Queries.TaskModelQueries;
using MediatorAPI_Auth.Queries.TeacherQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatorAPI_Auth.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExerciseController : ControllerBase
{
    private readonly IMediator _mediator;

    public ExerciseController(IMediator mediator) =>
        _mediator = mediator;

    [HttpGet]
    public async Task<List<Exercise>> GetTeacherListAsync()
    {
        var teacherDetails = await _mediator.Send(new GetExerciseListQuery());
        return teacherDetails;
    }
}
