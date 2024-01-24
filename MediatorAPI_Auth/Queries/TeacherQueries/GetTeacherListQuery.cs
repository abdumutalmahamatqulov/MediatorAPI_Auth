using MediatorAPI_Auth.Models;
using MediatR;

namespace MediatorAPI_Auth.Queries.TeacherQueries;

public class GetTeacherListQuery:IRequest<List<Teacher>>
{
}
