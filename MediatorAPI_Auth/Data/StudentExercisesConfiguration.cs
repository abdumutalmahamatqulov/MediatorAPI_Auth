using MediatorAPI_Auth.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediatorAPI_Auth.Data;

public class StudentExercisesConfiguration : IEntityTypeConfiguration<StudentExercises>
{
	public void Configure(EntityTypeBuilder<StudentExercises> builder)
	{
		builder.HasData(Data);
	}
	private List<StudentExercises> Data = new List<StudentExercises>
	{
		new StudentExercises
		{ 
			Id = 1,
			StudentId = 1,
			ExerciseId = 1
		},
		new StudentExercises
		{
			Id = 2,
			StudentId = 1,
			ExerciseId = 2
		},      
		new StudentExercises
		{
			Id = 3,
			StudentId = 1,
			ExerciseId = 3
		},
		new StudentExercises
		{
			Id = 4,
			StudentId = 2,
			ExerciseId = 1
		},      
		new StudentExercises
		{
			Id = 5,
			StudentId = 2,
			ExerciseId = 2
		},
		new StudentExercises
		{
			Id = 6,
			StudentId = 2,
			ExerciseId = 3
		},
	};
}
