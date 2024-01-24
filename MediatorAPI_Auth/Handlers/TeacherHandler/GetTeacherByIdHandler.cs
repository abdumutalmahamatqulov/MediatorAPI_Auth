using MediatorAPI_Auth.Interfaces;
using MediatorAPI_Auth.Models;
using MediatorAPI_Auth.Queries.TeacherQueries;
using MediatR;

namespace MediatorAPI_Auth.Handlers.TeacherHandler;

public class GetTeacherByIdHandler:IRequestHandler<GetTeacherByIdQuery, Teacher>
{
    private readonly ITeacherRepository _teacherRepository;

    public GetTeacherByIdHandler(ITeacherRepository teacherRepository) 
        => _teacherRepository = teacherRepository;

    public async Task<Teacher> Handle(GetTeacherByIdQuery query, CancellationToken cancellationToken) 
        => await _teacherRepository.GetTeacherByIdAsync(query.Id);
}
