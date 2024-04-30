using SPD.Entity.Models;

namespace SPD.Repository
{
    public interface ISPDRepository
    {
        List<Marksheet> GetMarksheetsByStudentId(Guid studentId);
        List<StudentMaster> GetStudentsByClass(int classId);
        void AddMark(Marksheet marksheet);
        void UpdateMark(Marksheet marksheet);
    }
}