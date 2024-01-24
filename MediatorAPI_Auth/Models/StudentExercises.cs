namespace MediatorAPI_Auth.Models;

public class StudentExercises
{
	public int Id { get; set; }
	public int StudentId { get; set; }
	public Student Student { get; set; }
	public int ExerciseId { get; set; }
	public Exercise Exercise { get; set; }
}
