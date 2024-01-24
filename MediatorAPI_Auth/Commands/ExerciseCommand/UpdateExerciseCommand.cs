using MediatorAPI_Auth.Models;
using MediatR;

namespace MediatorAPI_Auth.Commands.TaskModelCommand;

public class UpdateExerciseCommand:IRequest<int>
{
    public int Id { get; set; }
	public string TaskName { get; set; }
	public string Discraption { get; set; }
	public string Title { get; set; }
	public int TeacherId { get; set; }
	public Teacher Teacher { get; set; }

	public UpdateExerciseCommand(int id, string taskName, string discraption, 
		string title, int teacherId,Teacher teacher)
    {
        Id = id;
		TaskName = taskName;
		Discraption = discraption;
		Title = title;
		TeacherId = teacherId;
	}
}
