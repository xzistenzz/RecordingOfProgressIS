namespace RecordingOfProgressIS.Domain.Models
{
    public class DisciplineGroupProfessor
    {
        public int ProfessorId { get; set; }
        public Professor? Professor { get; set; }
        public int GroupId { get; set; }
        public Group? Group { get; set; }
        public int DisciplineId { get; set; }
        public AcademicDiscipline? Discipline { get; set; }
    }
}
