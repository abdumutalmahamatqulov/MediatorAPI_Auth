using System.Net.Mime;
using System.Text.Json;
using System.Text.Json.Serialization;
using MediatorAPI_Auth.Commands.TeacherCommand;
using MediatorAPI_Auth.Data;
using MediatorAPI_Auth.Models;
using MediatorAPI_Auth.Queries.TeacherQueries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MediatorAPI_Auth.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize(Roles = "ADMIN,TEACHER")]
public class TeachersController : ControllerBase
{
    private readonly  IMediator _mediator;
    readonly AppDbContext _context;
	public TeachersController(IMediator mediator, AppDbContext context)
	{
		_mediator = mediator;
		_context = context;
	}

	[HttpGet]
	public async Task<List<Teacher>> GetTeacherListAsync()
	{
		var teacherDetails = await _mediator.Send(new GetTeacherListQuery());
		var teacherwithStudents = await _context.Teachers
			.Include(x => x.TeacherStudents)  
				.ThenInclude(ts => ts.Student)
					.ThenInclude(s => s.StudentExercises)
		                .ThenInclude(se => se.Exercise)
			                .ToListAsync();

		var mergedTeachersList = teacherDetails.Concat(teacherwithStudents).ToList();
		return mergedTeachersList;
	}

	[HttpGet("teacheriId")]
    public async Task<Teacher>GetTeacherByIdAsync(int teacheriId)
    {
        var teacherDetails = await _mediator.Send(new GetTeacherByIdQuery(){ Id = teacheriId});

		var teacherWithStudents = await _context.Teachers
        .Include(t => t.TeacherStudents)
        .ThenInclude(ts => ts.Student)
        .ThenInclude(s => s.StudentExercises)
        .ThenInclude(se => se.Exercise)
        .FirstOrDefaultAsync(t => t.Id == teacheriId);

        teacherDetails.TeacherStudents = teacherWithStudents?.TeacherStudents;

        return teacherDetails;


    }
    [HttpPost]
    public async Task<Teacher>AddTeacherAsync(Teacher teacherDetails)
    {
        var teacherDetail = await _mediator.Send(new CreateTeacherCommand(
            teacherDetails.Name,
            teacherDetails.Level,
            teacherDetails.Science));
        return teacherDetail;
    }
    [HttpPut]
    public async Task <int>UpdateTeacherAsync(Teacher teacherDetails)
    {
        var isTeacherDetailUpdated = await _mediator.Send(new UpdateTeacherCommand(
            teacherDetails.Id,
            teacherDetails.Level,
            teacherDetails.Name,
            teacherDetails.Science
         ));
        return isTeacherDetailUpdated;
    }
    [HttpDelete]
    public async Task <int>DeleteTeacherAsymc(int id)
    {
        return await _mediator.Send(new DeleteTeacherCommand() { Id = id });
    }
}
