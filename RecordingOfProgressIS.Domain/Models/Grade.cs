namespace RecordingOfProgressIS.Domain.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int DisciplineId { get; set; }
        public AcademicDiscipline Discipline { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public int GradeValue { get; set; }
    }
}
