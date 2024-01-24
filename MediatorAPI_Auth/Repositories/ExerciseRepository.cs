using MediatorAPI_Auth.Data;
using MediatorAPI_Auth.Interfaces;
using MediatorAPI_Auth.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatorAPI_Auth.Repositories;

public class ExerciseRepository : IExerciseRepository
{
    private readonly AppDbContext _appDbContext;

    public ExerciseRepository(AppDbContext appDbContext) 
        => _appDbContext = appDbContext;

    public async Task<Exercise> AddExerciseAsync(Exercise taskDetails)
    {
        var result = _appDbContext.Exercises.Add(taskDetails);
        await _appDbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async  Task<int> DeleteExerciseAsync(int Id)
    {
        var filteredData = _appDbContext.Exercises.Where(x=>x.Id == Id).FirstOrDefault();
        _appDbContext.Exercises.Remove(filteredData);
        return await _appDbContext.SaveChangesAsync();
       
    }

    public async Task<Exercise> GetExerciseByIdAsync(int Id) 
        => await _appDbContext.Exercises.Where(x => x.Id == Id).FirstOrDefaultAsync();

    public async Task<List<Exercise>> GetExerciseListAsync() 
        => await _appDbContext.Exercises.ToListAsync();

    public async Task<int> UpdateExerciseAsync(Exercise taskDetails)
    {
         _appDbContext.Exercises.Update(taskDetails);
        return await _appDbContext.SaveChangesAsync();
    }
}
