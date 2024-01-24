using MediatorAPI_Auth.Commands.StudentCommand;
using MediatorAPI_Auth.Interfaces;
using MediatorAPI_Auth.Models;
using MediatR;

namespace MediatorAPI_Auth.Handlers.StudentHandler;

public class CreateStudentHandler : IRequestHandler<CreateStudentCommand, Student>
{
    private readonly IStudentRepository _studentRepository;

    public CreateStudentHandler(IStudentRepository studentRepository)
        => _studentRepository = studentRepository;

    public async Task<Student> Handle(CreateStudentCommand command, CancellationToken cancellationToken)
    {
        var studentDetails = new Student()
        {
            StudentName = command.StudentName,
            StudentEmail = command.StudentEmail,
            StudentAddress = command.StudentAddress,
            StudentAge = command.StudentAge
        };
        return await _studentRepository.AddStudentAsync(studentDetails);
    }
}
