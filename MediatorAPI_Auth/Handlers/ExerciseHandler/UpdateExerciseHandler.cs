using MediatorAPI_Auth.Commands.TaskModelCommand;
using MediatorAPI_Auth.Interfaces;
using MediatorAPI_Auth.Models;
using MediatR;

namespace MediatorAPI_Auth.Handlers.TaskModelHandler;

public class UpdateExerciseHandler : IRequestHandler<UpdateExerciseCommand, int>
{
    private readonly IExerciseRepository _taskModelRepository;

    public UpdateExerciseHandler(IExerciseRepository taskModelRepository) 
        => _taskModelRepository = taskModelRepository;

    public async Task<int> Handle(UpdateExerciseCommand command, CancellationToken cancellationToken)
    {
        var updateTaskModel = await _taskModelRepository.GetExerciseByIdAsync(command.Id);
        {
            updateTaskModel.Title = command.Title;
            updateTaskModel.Discraption = command.Discraption;

            return await _taskModelRepository.UpdateExerciseAsync(updateTaskModel);
        };
    }
}
