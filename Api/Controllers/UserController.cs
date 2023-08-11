using Application.IRepository;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Audit.WebApi;


namespace Api.Controllers
{
    [AuditApi(IncludeHeaders = true)]
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IEmployeeRepo _empRepo;

        private readonly ILogger<UserController> _logger;

        public UserController(IEmployeeRepo empRepo, ILogger<UserController> logger)
        {
            _empRepo = empRepo;
            _logger = logger;

        }
        [HttpGet]
        public ActionResult<IEnumerable<Employee1>> GetEmps()
        {
            var emps = _empRepo.GetAllEmployee();
            // _logger.LogInformation("GetEmps is triggered");
            // Utility.CreateFileLogs("Function: ", "Get",true,Utility.LogType.Get,Utility.FileExtentionType.json);
            return emps;
        }
        [HttpPost]
        public IActionResult  PostEmp(Employee1 Emp)
        {
            var NewEmp = _empRepo.PostEmployee(Emp);
            return CreatedAtAction(nameof(GetEmps), new { EmpNum = Emp.EmpNum }, Emp);
        }
        [HttpDelete]
        public IActionResult DeleteEmp(int EmpNum)
        {
            _empRepo.DeleteEmployee(EmpNum);
            return Ok("true");
        }
    }
}