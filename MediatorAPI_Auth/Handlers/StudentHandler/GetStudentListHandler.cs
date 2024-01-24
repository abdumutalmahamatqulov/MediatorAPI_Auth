using MediatorAPI_Auth.Interfaces;
using MediatorAPI_Auth.Models;
using MediatorAPI_Auth.Queries.StudentQueries;
using MediatR;

namespace MediatorAPI_Auth.Handlers.StudentHandler
{
    internal sealed record GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<Student>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentListHandler(IStudentRepository studentRepository)
            => _studentRepository = studentRepository;

        public async Task<List<Student>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
            => await _studentRepository.GetStudentListAsync();
    }
}
