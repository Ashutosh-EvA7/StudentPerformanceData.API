using SPD.Entity.Models;

namespace SPD.Repository
{
    public class SPDRepository(SpdContext context) : ISPDRepository
    {
        private readonly SpdContext _context = context ?? throw new ArgumentNullException(nameof(context));

        public List<Marksheet> GetMarksheetsByStudentId(Guid studentId)
        {
            return [.. _context.Marksheets.Where(m => m.StudentId == studentId)];
        }

        public List<StudentMaster> GetStudentsByClass(int classId)
        {
            return [.. _context.StudentMasters.Where(s => s.Class == classId)];
        }

        public void AddMark(Marksheet marksheet)
        {
            _context.Marksheets.Add(marksheet);
            _context.SaveChanges();
        }

        public void UpdateMark(Marksheet marksheet)
        {
            _context.Marksheets.Update(marksheet);
            _context.SaveChanges();
        }

        List<Marksheet> ISPDRepository.GetMarksheetsByStudentId(Guid studentId)
        {
            throw new NotImplementedException();
        }

        List<StudentMaster> ISPDRepository.GetStudentsByClass(int classId)
        {
            throw new NotImplementedException();
        }
    }
}