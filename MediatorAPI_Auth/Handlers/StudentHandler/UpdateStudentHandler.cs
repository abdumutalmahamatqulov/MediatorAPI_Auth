﻿using MediatorAPI_Auth.Commands.StudentCommand;
using MediatorAPI_Auth.Interfaces;
using MediatR;

namespace MediatorAPI_Auth.Handlers.StudentHandler;

public class UpdateStudentHandler : IRequestHandler<UpdateStudentCommand, int>
{
    private readonly IStudentRepository _studentRepository;

    public UpdateStudentHandler(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }
    public async Task<int> Handle(UpdateStudentCommand command, CancellationToken cancellationToken)
    {
        var studentDetails = await _studentRepository.GetStudentByIdAsync(command.Id);
        studentDetails.Id = command.Id;
        studentDetails.StudentName = command.StudentName;
        studentDetails.StudentEmail = command.StudentEmail;
        studentDetails.StudentAddress = command.StudentAddress;
        studentDetails.StudentAge = command.StudentAge;

        return await _studentRepository.UpdateStudentAsync(studentDetails);
    }
}
