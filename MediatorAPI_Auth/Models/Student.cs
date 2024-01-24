namespace MediatorAPI_Auth.Models;
public class Student 
{
    public int Id { get; set; }
    public string StudentName { get; set; }
    public string StudentEmail { get; set; }
    public string StudentAddress { get; set; }
    public int StudentAge { get; set; }
    public ICollection<StudentExercises> StudentExercises { get; set; }
}

