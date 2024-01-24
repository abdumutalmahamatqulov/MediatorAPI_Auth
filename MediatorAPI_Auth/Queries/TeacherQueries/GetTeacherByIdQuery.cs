using MediatorAPI_Auth.Models;
using MediatR;

namespace MediatorAPI_Auth.Queries.TeacherQueries;

public class GetTeacherByIdQuery:IRequest<Teacher>
{
    public int Id { get; set; }
}
