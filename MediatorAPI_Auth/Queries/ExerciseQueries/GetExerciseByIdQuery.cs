using MediatorAPI_Auth.Models;
using MediatR;

namespace MediatorAPI_Auth.Queries.TaskModelQueries;

public class GetExerciseByIdQuery:IRequest<Exercise>
{
    public int Id { get; set; }
}
