using MediatorAPI_Auth.Models;
using MediatR;

namespace MediatorAPI_Auth.Queries.StudentQueries;

public class GetStudentByIdQuery : IRequest<Student>
{
    public int Id { get; set; }
}
