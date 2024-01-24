using MediatorAPI_Auth.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace MediatorAPI_Auth.Data;

public class AppDbContext : IdentityDbContext<User>
{
    public AppDbContext(DbContextOptions<AppDbContext> options, IServiceProvider services) : base(options)
    {
        this.Services = services;
    }

    public IServiceProvider Services { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet <Exercise> Exercises { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);


        builder.Entity<Student>()
            .HasMany(x =>x.StudentExercises)
            .WithOne(g => g.Student)
            .HasForeignKey(x => x.StudentId);

		builder.Entity<TeacherStudents>()
	        .HasOne(ts => ts.Teacher)
	        .WithMany(t => t.TeacherStudents)
	        .HasForeignKey(ts => ts.TeacherId);

		builder.Entity<Teacher>()
            .HasMany(ts =>ts.TeacherStudents)
            .WithOne(g => g.Teacher)
            .HasForeignKey(x => x.TeacherId);


        builder.ApplyConfiguration<IdentityRole>(new RoleConfiguration(Services));
        builder.ApplyConfiguration(new TeacherConfiguration());
        builder.ApplyConfiguration(new StudentConfiguration());
        builder.ApplyConfiguration(new ExerciseConfiguration());
        builder.ApplyConfiguration(new TeacherStudentsConfiguration());
        builder.ApplyConfiguration(new StudentExercisesConfiguration());
    }

}
