using MediatorAPI_Auth.Models;
using MediatR;

namespace MediatorAPI_Auth.Commands.TaskModelCommand;

public class CreateExerciseCommand:IRequest<Exercise>
{
	public string TaskName { get; set; }
	public string Discraption { get; set; }
	public string Title { get; set; }
	public int TeacherId { get; set; }
	public Teacher Teacher { get; set; }
	public int GroupId { get; set; }

	public CreateExerciseCommand(string taskName, string discraption, string title,
		Teacher teacher,int teacherId,int groupId)
    {
        TaskName = taskName;
        Discraption = discraption;
        Title = title;
		TeacherId = teacherId;
		GroupId = groupId;
    }
}
