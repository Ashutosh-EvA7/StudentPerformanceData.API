using Microsoft.AspNetCore.Mvc;
using SPD.Entity.Models;
namespace StudentPerformanceData.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentPerformanceController(ISPDBusiness business) : ControllerBase
    {
        public readonly ISPDBusiness _business = business;

        [HttpGet("GetTotalMarkObtained")]
        public decimal GetTotalMarkObtained([FromHeader] Guid studentId)
        {
            return _business.GetTotalMarkObtained(studentId);
        }

        [HttpGet("GetTotalPercentageObtained")]
        public decimal GetTotalPercentageObtained([FromHeader] Guid studentId)
        {
            return _business.GetTotalPercentageObtained(studentId);
        }

        [HttpGet("GetAllMarksById")]
        public List<Marksheet> GetAllMarksById([FromHeader] Guid studentId)
        {
            return _business.GetAllMarksById(studentId);
        }

        [HttpPost("AddMarks")]
        public void AddMarks([FromBody] Marksheet request)
        {
            _business.AddMarks(request);
        }

        [HttpPut("UpdateMarks")]
        public void UpdateMarks([FromBody] Marksheet request)
        {
            _business.UpdateMarks(request);
        }

        [HttpGet("GetStudentList")]
        public List<StudentMaster> GetStudentList([FromHeader] int classId)
        {
            return _business.GetStudentList(classId);
        }

        [HttpGet("GetTopThree")]
        public List<StudentMaster> GetTopThree([FromHeader] int classId)
        {
            return _business.GetTopThree(classId);
        }
    }
}