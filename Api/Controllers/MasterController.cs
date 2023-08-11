using Application.IRepository;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MasterController : ControllerBase
    {
        private readonly IEmployeeRepo _empRepo;

        public MasterController(IEmployeeRepo empRepo)
        {
            _empRepo = empRepo;
        }   
        [HttpGet]
        public ActionResult<object> GetEmpDept()
        {
            return _empRepo.GetEmpAndDept();
        }
        [HttpPost]
        public IActionResult PostEmpAndDept(MasterClass detail)
        {
            var details = _empRepo.PostEmpAndDept(detail);
            return CreatedAtAction(nameof(GetEmpDept), details);
        }
        [HttpDelete]
        public IActionResult DeleteEmpAndDept(int DeptId)
        {
            var detail = _empRepo.DeleteEmpAndDept(DeptId);
            return Ok(true);
        }
    }
}