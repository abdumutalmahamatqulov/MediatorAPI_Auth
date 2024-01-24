using MediatorAPI_Auth.Commands.TeacherCommand;
using MediatorAPI_Auth.Interfaces;
using MediatorAPI_Auth.Models;
using MediatR;

namespace MediatorAPI_Auth.Handlers.TeacherHandler;

public class CreateTeacherHandler:IRequestHandler<CreateTeacherCommand, Teacher>
{
    private readonly ITeacherRepository _teacherRepository;

    public CreateTeacherHandler(ITeacherRepository teacherRepository) 
        => _teacherRepository = teacherRepository;

    public async Task <Teacher>Handle(CreateTeacherCommand command, CancellationToken cancellationToken)
    {
        var teacherDetails = new Teacher()
        {
            Name = command.Name,
            Level = command.Level,
            Science = command.Science
        };
        return await _teacherRepository.AddTeacherAsync(teacherDetails);
    }

}
