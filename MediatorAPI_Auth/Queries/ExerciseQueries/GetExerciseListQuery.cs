using MediatorAPI_Auth.Models;
using MediatR;
namespace MediatorAPI_Auth.Queries.TaskModelQueries;

public class GetExerciseListQuery : IRequest<List<Exercise>>
{
}
