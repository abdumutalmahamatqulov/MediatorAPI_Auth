using MediatorAPI_Auth.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediatorAPI_Auth.Data;

public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
{
    public void Configure(EntityTypeBuilder<Teacher> builder)
    {
        builder.HasData(Data);
    }
    private List<Teacher> Data = new List<Teacher>
    {
        new Teacher
        {
            Id = 1,
            Name = "Bachuayee",
            Science = "Math",
            Level = "Senior",
        },
        new Teacher
        {
            Id = 2,
            Name = "Chaluba",
            Science = "Kimyo",
            Level = "Middle",
        },
        new Teacher
        {
            Id = 3,
            Name = "Chukveza",
            Science = "Informatika",
            Level = "Jenior",
        },
        new Teacher
        {
            Id = 4,
            Name = "chupo Moting",
            Science = "bialogiya",
            Level = "Good",
        },
        new Teacher
        {
            Id = 5,
            Name = "Salah",
            Science = "Biosfera",
            Level = "Strong Jenior",
        },
        new Teacher
        {
            Id = 6,
            Name = "Qodirali",
            Science = "Rus Tili",
            Level = "Strong Middle",
        },
        new Teacher
        {
            Id = 7,
            Name = "Son",
            Science = "Ona Tili",
            Level = "Academic",
        },
        new Teacher
        {
            Id = 8,
            Name = "Sinyorita",
            Science = "Geografiya",
            Level = "Well",
        },
         new Teacher
        {
            Id = 9,
            Name = "Vasvasagin",
            Science = "Fizika",
            Level = "Jenior",
        },
        new Teacher
        {
            Id = 10,
            Name = "Jalil",
            Science = "Math",
            Level = "Jenior",
        },
    };
}
