using System.Diagnostics.CodeAnalysis;
using Application.IRepository;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;


namespace Infrastructure.Repository
{
    public class EmployeeRepository : IEmployeeRepo
    {
        private readonly TrainingContext _dbcontext;
        private readonly ILogger<EmployeeRepository> logger;
        public EmployeeRepository(TrainingContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public List<Employee1> GetAllEmployee()
        {
            return _dbcontext.Employees1.ToList();
        }

        public Employee1 PostEmployee(Employee1 emp)
        {
            var newEmp = _dbcontext.Employees1.Add(emp);
            _dbcontext.SaveChanges();
            return emp;
        }

        public Employee1 DeleteEmployee(int EmpNum)
        {
            var existemp = _dbcontext.Employees1.Find(EmpNum);
            _dbcontext.Employees1.Remove(existemp);
            _dbcontext.SaveChanges();
            return existemp;
        }

        public object GetEmpAndDept()
        {
            var details = (from e in _dbcontext.Newempmasts
              join d in _dbcontext.Newdeptmasts
              on e.DeptId equals d.DeptId
              group e by new { d.DeptId, d.DeptName } into g
              select new
              {
                  Dept_Id = g.Key.DeptId,
                  Dept_Name = g.Key.DeptName,
                  Employees = g.Select(e => new
                  {
                      Emp_Id = e.EmpId,
                      Emp_Name = e.EmpName,
                      Emp_Salary = e.EmpSalary,
                      Emp_DeptId = e.DeptId
                  }).ToList()
              }).ToList();
            return details;
        }

        public MasterClass PostEmpAndDept(MasterClass detail)
        {
            using(IDbContextTransaction transaction = _dbcontext.Database.BeginTransaction())
            {
                try
                {
                    detail.Newempmasts.ForEach(x =>
                        {
                            var emp = new Newempmast()
                            {
                                EmpId = x.EmpId,
                                EmpName = x.EmpName,
                                EmpSalary = x.EmpSalary,
                                DeptId = detail.Newdeptmast.DeptId,
                                ManagerId = x.ManagerId,
                                Phoneno = x.Phoneno
                            };
                            _dbcontext.Newempmasts.Add(emp);
                        });

                    _dbcontext.Newdeptmasts.Add(detail.Newdeptmast);

                    _dbcontext.SaveChanges();
                    transaction.Commit();
                    return detail;
                }
                catch (System.Exception ex)
                {
                    transaction.Rollback();
                }
            }
            return detail;
        }

        public MasterClass DeleteEmpAndDept(int DeptId)
        {
            using(IDbContextTransaction transaction = _dbcontext.Database.BeginTransaction())
            {
                try
                {
                    MasterClass mclass = new MasterClass();
                    var existemp = _dbcontext.Newempmasts.Find(DeptId);
                    _dbcontext.Newempmasts.Remove(existemp);
                    _dbcontext.SaveChanges();
        
                    var existdept = _dbcontext.Newdeptmasts.Find(DeptId);
                    _dbcontext.Newdeptmasts.Remove(existdept);
                    _dbcontext.SaveChanges();

                    transaction.Commit();
                    return mclass;
                }
                catch (System.Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}