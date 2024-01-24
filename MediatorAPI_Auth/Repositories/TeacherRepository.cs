using MediatorAPI_Auth.Data;
using MediatorAPI_Auth.Interfaces;
using MediatorAPI_Auth.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatorAPI_Auth.Repositories;

public class TeacherRepository : ITeacherRepository
{
    private readonly AppDbContext _dbContext;

    public TeacherRepository(AppDbContext dbContext) => _dbContext = dbContext;

    public async  Task<Teacher> AddTeacherAsync(Teacher teacherDetails)
    {
        var result = _dbContext.Teachers.Add(teacherDetails);
        await _dbContext.SaveChangesAsync();
        return result.Entity;
    }

    public async  Task<int> DeleteTeacherAsync(int Id)
    {
        var filteredData = _dbContext.Teachers.Where(x => x.Id == Id).FirstOrDefault();
        _dbContext.Teachers.Remove(filteredData);
        return await _dbContext.SaveChangesAsync();
    }

    public async Task<Teacher> GetTeacherByIdAsync(int Id) 
        => await _dbContext.Teachers.Where(x => x.Id == Id).FirstOrDefaultAsync();

    public async Task<List<Teacher>> GetTeacherListAsync()
        => await _dbContext.Teachers.ToListAsync();

    public async  Task<int> UpdateTeacherAsync(Teacher teacherDetails)
    {
        _dbContext.Teachers.Update(teacherDetails);
        return await _dbContext.SaveChangesAsync();
    }
}
