using MediatorAPI_Auth.Commands.TaskModelCommand;
using MediatorAPI_Auth.Interfaces;
using MediatorAPI_Auth.Models;
using MediatR;

namespace MediatorAPI_Auth.Handlers.TaskModelHandler;

public class CreateExerciseHandler : IRequestHandler<CreateExerciseCommand, Exercise>
{
    private readonly IExerciseRepository _taskModelRepository;

    public CreateExerciseHandler(IExerciseRepository taskModelRepository) 
        => _taskModelRepository = taskModelRepository;

    public async Task <Exercise>Handle(CreateExerciseCommand command,CancellationToken cancellationToken)
    {
        var TaskDetails = new Exercise()
        {
            TaskName = command.TaskName,
            Title = command.Title,
            Discraption = command.Discraption
        };
        return await _taskModelRepository.AddExerciseAsync(TaskDetails);
    }
}
