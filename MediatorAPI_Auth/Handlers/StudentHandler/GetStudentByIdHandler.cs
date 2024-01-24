using MediatorAPI_Auth.Interfaces;
using MediatorAPI_Auth.Models;
using MediatorAPI_Auth.Queries.StudentQueries;
using MediatR;

namespace MediatorAPI_Auth.Handlers.StudentHandler
{
    public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, Student>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentByIdHandler(IStudentRepository studentRepository)
            => _studentRepository = studentRepository;

        public async Task<Student> Handle(GetStudentByIdQuery query, CancellationToken cancellationToken)
            => await _studentRepository.GetStudentByIdAsync(query.Id);
    }
}
