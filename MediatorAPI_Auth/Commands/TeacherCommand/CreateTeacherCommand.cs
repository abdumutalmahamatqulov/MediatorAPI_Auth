using MediatorAPI_Auth.Models;
using MediatR;

namespace MediatorAPI_Auth.Commands.TeacherCommand;

public class CreateTeacherCommand:IRequest<Teacher>
{

    public string Name { get; set; }
    public string Level { get; set; }
    public string Science { get; set; }
    public CreateTeacherCommand(string teacherName, string teacherLevel, string teacherScience)
    {
        Name = teacherName;
        Level = teacherLevel;
        Science = teacherScience;
    }

}
