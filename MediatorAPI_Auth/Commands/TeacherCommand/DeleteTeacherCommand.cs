using MediatR;

namespace MediatorAPI_Auth.Commands.TeacherCommand;

public class DeleteTeacherCommand:IRequest<int>
{
    public int Id { get; set; }
}
