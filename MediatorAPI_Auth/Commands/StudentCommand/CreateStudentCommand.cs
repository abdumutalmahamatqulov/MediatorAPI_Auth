using MediatorAPI_Auth.Models;
using MediatR;

namespace MediatorAPI_Auth.Commands.StudentCommand;

public class CreateStudentCommand : IRequest<Student>
{
    public string StudentName { get; set; }
    public string StudentEmail { get; set; }
    public string StudentAddress { get; set; }
    public int StudentAge { get; set; }

    public CreateStudentCommand(string studentName, string studentEmail, string studentAddress, int studentAge)
    {
        StudentName = studentName;
        StudentEmail = studentEmail;
        StudentAddress = studentAddress;
        StudentAge = studentAge;
    }
}
