using MediatR;

namespace MediatorAPI_Auth.Commands.StudentCommand;

public class DeleteStudentCommand : IRequest<int>
{
    public int Id { get; set; }
}
