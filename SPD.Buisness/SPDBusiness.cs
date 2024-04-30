using AutoMapper;
using SPD.Entity.Models;
using SPD.Repository;
using SPD.Business;

namespace SPDBusiness
{
    public class SPDBusiness(ISPDRepository repository, IMapper mapper) : ISPDBusiness
    {
        private readonly ISPDRepository _repository = repository;
        private readonly IMapper _mapper = mapper;

        public decimal GetTotalMarkObtained(Guid studentId)
        {
            var marksheets = _repository.GetMarksheetsByStudentId(studentId);
            return (decimal)marksheets.Sum(m => m.MarksObtained);
        }

        public decimal GetTotalPercentageObtained(Guid studentId)
        {
            var marksheets = _repository.GetMarksheetsByStudentId(studentId);
            var totalMarks = marksheets.Sum(m => m.TotalMark);
            var totalObtained = marksheets.Sum(m => m.MarksObtained);
            return (decimal)(totalObtained / totalMarks * 100);
        }

        public List<Marksheet> GetAllMarksById(Guid studentId)
        {
            var marksheets = _repository.GetMarksheetsByStudentId(studentId);
            return _mapper.Map<List<Marksheet>>(marksheets);
        }

        public void AddMarks(Marksheet request)
        {
            var marksheet = _mapper.Map<Marksheet>(request);
            _repository.AddMark(marksheet);
        }

        public void UpdateMarks(Marksheet request)
        {
            var marksheet = _mapper.Map<Marksheet>(request);
            _repository.UpdateMark(marksheet);
        }

        public List<StudentMaster> GetStudentList(int classId)
        {
            var students = _repository.GetStudentsByClass(classId);
            return _mapper.Map<List<StudentMaster>>(students);
        }

        public List<StudentMaster> GetTopThree(int classId)
        {
            var students = _repository.GetStudentsByClass(classId);
            var topThree = students.OrderByDescending(s => s.TotalMarkObtained).Take(3);
            return _mapper.Map<List<StudentMaster>>(topThree);
        }

        List<Marksheet> ISPDBusiness.GetAllMarksById(Guid studentId)
        {
            throw new NotImplementedException();
        }


        List<StudentMaster> ISPDBusiness.GetStudentList(int classId)
        {
            throw new NotImplementedException();
        }

        List<StudentMaster> ISPDBusiness.GetTopThree(int classId)
        {
            throw new NotImplementedException();
        }
    }
}