using MediatR;

namespace MediatorAPI_Auth.Commands.TaskModelCommand;

public class DeleteExerciseCommand:IRequest<int>
{
    public int Id { get; set; }
}
