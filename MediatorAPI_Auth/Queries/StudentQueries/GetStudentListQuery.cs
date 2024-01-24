using MediatorAPI_Auth.Models;
using MediatR;

namespace MediatorAPI_Auth.Queries.StudentQueries;

public class GetStudentListQuery : IRequest<List<Student>>
{
}
