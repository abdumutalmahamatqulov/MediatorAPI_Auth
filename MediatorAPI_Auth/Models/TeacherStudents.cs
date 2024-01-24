using System.ComponentModel.DataAnnotations.Schema;

namespace MediatorAPI_Auth.Models;

public class TeacherStudents
{
	public int Id { get; set; }
	public int StudentId { get; set;}
	public Student Student { get; set;}
	public int TeacherId { get; set; }
	public Teacher Teacher { get; set; }
}
