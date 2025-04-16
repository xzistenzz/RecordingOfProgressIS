namespace RecordingOfProgressIS.Domain.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public List<AcademicDiscipline> Disciplines { get; set; }
        public List<Grade> Grades { get; set; }
        public List<DisciplineGroupProfessor> DisciplineGroupProfessors { get; set; }
    }
}
