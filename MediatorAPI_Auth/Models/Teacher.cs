namespace MediatorAPI_Auth.Models;

public class Teacher 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Level { get; set; }
    public string Science { get; set; }
    public ICollection<TeacherStudents> TeacherStudents { get; set; }
}
