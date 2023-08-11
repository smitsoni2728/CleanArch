using Domain.Models;

namespace Application.IRepository
{
    public interface IEmployeeRepo
    {
        public List<Employee1> GetAllEmployee();

        public Employee1 PostEmployee(Employee1 emp);

        public Employee1 DeleteEmployee(int EmpNum);

        public object GetEmpAndDept();

        public MasterClass PostEmpAndDept(MasterClass detail);

        public MasterClass DeleteEmpAndDept(int DeptId);
    }
}