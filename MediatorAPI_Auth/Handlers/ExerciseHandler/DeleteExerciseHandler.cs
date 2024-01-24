using MediatorAPI_Auth.Commands.TaskModelCommand;
using MediatorAPI_Auth.Interfaces;
using MediatR;

namespace MediatorAPI_Auth.Handlers.TaskModelHandler;

public sealed record DeleteExerciseHandler:IRequestHandler<DeleteExerciseCommand, int>
{
    private readonly IExerciseRepository _taskModelRepository;

    public DeleteExerciseHandler(IExerciseRepository taskModelRepository) 
        => _taskModelRepository = taskModelRepository;

    public async Task <int>Handle(DeleteExerciseCommand command,CancellationToken cancellationToken)
    {
        var DeleteDetails = await _taskModelRepository.GetExerciseByIdAsync(command.Id);
        if(DeleteDetails == null)
            return default;

        return  await _taskModelRepository.DeleteExerciseAsync(command.Id);
    }
}
