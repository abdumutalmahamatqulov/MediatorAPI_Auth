using MediatorAPI_Auth.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediatorAPI_Auth.Data;

public class TeacherStudentsConfiguration : IEntityTypeConfiguration<TeacherStudents>

{
	public void Configure(EntityTypeBuilder<TeacherStudents> builder)
	{
		builder.HasData(Data);
	}
	List<TeacherStudents> Data = new List<TeacherStudents>
	{
		new TeacherStudents
		{
			Id = 1,
			TeacherId = 1,
			StudentId = 1
		},
		new TeacherStudents
		{
			Id = 2,
			TeacherId = 1,
			StudentId = 2
		},  
		new TeacherStudents
		{
			Id = 3,
			TeacherId = 1,
			StudentId = 3
		},
		new TeacherStudents
		{
			Id = 4,
			TeacherId = 2,
			StudentId = 1
		},
		new TeacherStudents
		{
			Id = 5,
			TeacherId = 2,
			StudentId = 2
		},
		new TeacherStudents
		{
			Id = 6,
			TeacherId = 2,
			StudentId = 3
		},
		new TeacherStudents
		{
			Id = 7,
			TeacherId = 3,
			StudentId = 1
		},
		new TeacherStudents
		{
			Id = 8,
			TeacherId = 3,
			StudentId = 2
		},
		new TeacherStudents
		{
			Id = 9,
			TeacherId = 3,
			StudentId = 3
		},
	};
}
