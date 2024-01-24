using MediatorAPI_Auth.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MediatorAPI_Auth.Data;

public class ExerciseConfiguration : IEntityTypeConfiguration<Exercise>
{
    public void Configure(EntityTypeBuilder<Exercise> builder)
    {
        builder.HasData(Data);
    }
    private List<Exercise> Data = new List<Exercise>
    {
        new Exercise
        {
            Id = 1,
            TaskName = "Math",
            Discraption = "10 mashq",
            Title = "Hosila"
        },
        new Exercise
        {
            Id = 2,
            TaskName = "Bialogiya",
            Discraption = "15 Mashq",
            Title = "tabiat yaralishi "
        },
        new Exercise
        {
            Id = 3,
            TaskName = "Ona-tili",
            Discraption = "18 mashq",
            Title = "sher"
        },
        new Exercise
        {
            Id = 4,
            TaskName = "Vatantuyg'usi",
            Discraption = "11 Mavzu",
            Title = "vatan bordir "
        },
        new Exercise
        {
            Id = 5,
            TaskName = "adabiyot",
            Discraption = "56 Mavzu",
            Title = "O'tkir Hoshimov"
        },
    };
}
