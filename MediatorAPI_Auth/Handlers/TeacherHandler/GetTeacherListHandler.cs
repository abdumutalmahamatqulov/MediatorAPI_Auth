using MediatorAPI_Auth.Interfaces;
using MediatorAPI_Auth.Models;
using MediatorAPI_Auth.Queries.TeacherQueries;
using MediatR;

namespace MediatorAPI_Auth.Handlers.TeacherHandler;

public class GetTeacherListHandler:IRequestHandler<GetTeacherListQuery,List<Teacher>>
{
    private readonly ITeacherRepository _teacherRepository;

    public GetTeacherListHandler(ITeacherRepository teacherRepository) 
        => _teacherRepository = teacherRepository;
    public async Task<List<Teacher>> Handle(GetTeacherListQuery query, CancellationToken cancellationToken) 
        => await _teacherRepository.GetTeacherListAsync();
}
