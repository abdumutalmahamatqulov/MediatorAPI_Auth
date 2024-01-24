using MediatorAPI_Auth.Models;
using MediatR;

namespace MediatorAPI_Auth.Commands.TeacherCommand;

public class UpdateTeacherCommand:IRequest<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Level { get; set; }
    public string Science { get; set; }
    public UpdateTeacherCommand(int id, string name, string level, string science)
    {
        Id = id;
        Name = name;
        Level = level;
        Science = science;
    }

}
