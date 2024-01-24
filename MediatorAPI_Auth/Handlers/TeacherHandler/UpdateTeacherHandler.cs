using MediatorAPI_Auth.Commands.TeacherCommand;
using MediatorAPI_Auth.Interfaces;
using MediatR;

namespace MediatorAPI_Auth.Handlers.TeacherHandler
{
    public class UpdateTeacherHandler:IRequestHandler<UpdateTeacherCommand,int>
    {
        private readonly ITeacherRepository _teacherRepository;

        public UpdateTeacherHandler(ITeacherRepository teacherRepository) => 
            _teacherRepository = teacherRepository;

        public async Task <int>Handle(UpdateTeacherCommand command,CancellationToken cancellationToken)
        {
            var teacherDetails = await _teacherRepository.GetTeacherByIdAsync(command.Id);
            teacherDetails.Name = command.Name;
            teacherDetails.Level = command.Level;
            teacherDetails.Science = command.Science;

            return await _teacherRepository.UpdateTeacherAsync(teacherDetails);
        }
    }
}
