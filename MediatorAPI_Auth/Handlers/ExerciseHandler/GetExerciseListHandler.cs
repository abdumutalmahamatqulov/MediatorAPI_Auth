using MediatorAPI_Auth.Interfaces;
using MediatorAPI_Auth.Models;
using MediatorAPI_Auth.Queries.TaskModelQueries;
using MediatR;

namespace MediatorAPI_Auth.Handlers.TaskModelHandler;

public class GetExerciseListHandler : IRequestHandler<GetExerciseListQuery, List<Exercise>>
{
    private readonly IExerciseRepository _taskModelRepository;

    public GetExerciseListHandler(IExerciseRepository taskModelRepository) 
        => _taskModelRepository = taskModelRepository;

    public async Task<List<Exercise>> Handle(GetExerciseListQuery query, CancellationToken cancellationToken)
    {
        return await _taskModelRepository.GetExerciseListAsync();
    }
}
