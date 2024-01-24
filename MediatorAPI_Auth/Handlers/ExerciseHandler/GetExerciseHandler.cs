using MediatorAPI_Auth.Interfaces;
using MediatorAPI_Auth.Models;
using MediatorAPI_Auth.Queries.TaskModelQueries;
using MediatR;

namespace MediatorAPI_Auth.Handlers.TaskModelHandler;

public sealed record GetExerciseHandler:IRequestHandler<GetExerciseByIdQuery, Exercise>
{
    private readonly IExerciseRepository _taskModelRepository;

    public GetExerciseHandler(IExerciseRepository taskModelRepository) 
        => _taskModelRepository = taskModelRepository;

    public async Task<Exercise> Handle(GetExerciseByIdQuery query, CancellationToken cancellationToken) 
        => await _taskModelRepository.GetExerciseByIdAsync(query.Id);
}
