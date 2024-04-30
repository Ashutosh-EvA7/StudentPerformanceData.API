using SPD.Entity.Models;

namespace SPD.Business
{
    public interface ISPDBusiness
    {
        decimal GetTotalMarkObtained(Guid studentId);
        decimal GetTotalPercentageObtained(Guid studentId);
        List<Marksheet> GetAllMarksById(Guid studentId);
        void AddMarks(Marksheet request);
        void UpdateMarks(Marksheet request);
        List<StudentMaster> GetStudentList(int classId);
        List<StudentMaster> GetTopThree(int classId);
    }
}