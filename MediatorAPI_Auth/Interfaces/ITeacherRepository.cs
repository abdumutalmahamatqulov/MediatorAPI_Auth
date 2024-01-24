using MediatorAPI_Auth.Models;

namespace MediatorAPI_Auth.Interfaces;

public interface ITeacherRepository
{
    public Task<List<Teacher>> GetTeacherListAsync();
    public Task<Teacher> GetTeacherByIdAsync(int Id);
    public Task<Teacher> AddTeacherAsync(Teacher teacherDetails);
    public Task<int> UpdateTeacherAsync(Teacher teacherDetails);
    public Task<int> DeleteTeacherAsync(int Id);
}
