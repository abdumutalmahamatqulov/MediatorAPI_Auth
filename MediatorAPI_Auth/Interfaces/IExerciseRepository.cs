using MediatorAPI_Auth.Models;

namespace MediatorAPI_Auth.Interfaces;

public interface IExerciseRepository
{
    public Task<List<Exercise>> GetExerciseListAsync();
    public Task<Exercise> GetExerciseByIdAsync(int Id);
    public Task<Exercise> AddExerciseAsync(Exercise taskDetails);
    public Task<int> UpdateExerciseAsync(Exercise taskDetails);
    public Task<int> DeleteExerciseAsync(int Id);
}
