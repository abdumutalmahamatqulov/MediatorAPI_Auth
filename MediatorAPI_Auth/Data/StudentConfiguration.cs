using MediatorAPI_Auth.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediatorAPI_Auth.Data;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasData(Data);
    }
    private List<Student> Data = new List<Student>
    {
        new Student 
        {
            Id = 1,
            StudentName = "Qobil",
            StudentAddress = "Zangiota",
            StudentEmail = "qobil@gmail.com",
            StudentAge = 10,
        },
        new Student
        {
            Id = 2,
            StudentName = "Qodir",
            StudentAddress = "Yangiyo'l",
            StudentEmail = "qodir@gmail.com",
            StudentAge = 18,
        },
        new Student
        {
            Id = 3,
            StudentName = "Qaxor",
            StudentAddress = "Chinoz",
            StudentEmail = "qaxor@gmail.com",
            StudentAge = 12,
        },
        new Student
        {
            Id = 4,
            StudentName = "Qodirali",
            StudentAddress = "Chilonzor",
            StudentEmail = "qodirali@gmail.com",
            StudentAge = 15,
        },
        new Student
        {
            Id = 5,
            StudentName = "Talos",
            StudentAddress = "Vodiy",
            StudentEmail = "talos@gmail.com",
            StudentAge = 8,
        },
        new Student
        {
            Id = 6,
            StudentName = "Temur",
            StudentAddress = "Toshkent",
            StudentEmail = "temur@gmail.com",
            StudentAge = 16,
        },
		new Student
        {
            Id = 7,
            StudentName = "Turon",
            StudentAddress = "Toshkent",
            StudentEmail = "turon@gmail.com",
            StudentAge = 14,
        },
        new Student
        {
            Id = 8,
            StudentName = "Tarichili",
            StudentAddress = "Toshkent",
            StudentEmail = "tarichili@gmail.com",
            StudentAge = 13,
        },
    };
}
