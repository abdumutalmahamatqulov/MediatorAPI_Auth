using System.Reflection.Metadata.Ecma335;
using MediatorAPI_Auth.Commands.TeacherCommand;
using MediatorAPI_Auth.Interfaces;
using MediatorAPI_Auth.Models;
using MediatorAPI_Auth.Repositories;
using MediatR;

namespace MediatorAPI_Auth.Handlers.TeacherHandler;

public sealed record DeleteTeacherHandler:IRequestHandler<DeleteTeacherCommand,int>
{
    private readonly ITeacherRepository _teacherRepository;

    public DeleteTeacherHandler(ITeacherRepository teacherRepository) => 
        _teacherRepository = teacherRepository;
    public async Task <int>Handle(DeleteTeacherCommand command, CancellationToken cancellationToken)
    {
        var teacherDetails = await _teacherRepository.GetTeacherByIdAsync(command.Id);
        if (teacherDetails == null)
            return default;

        return await _teacherRepository.DeleteTeacherAsync(teacherDetails.Id);
    }
}
