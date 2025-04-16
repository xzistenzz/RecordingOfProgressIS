namespace RecordingOfProgressIS.Domain.Models
{
    public class AcademicDiscipline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Group> Groups { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Grade> Grades { get; set; }
        public List<DisciplineGroupProfessor> DisciplineGroupProfessors { get; set; }
    }
}
