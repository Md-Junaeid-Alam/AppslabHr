using EntityModel.EntityModels;
using Microsoft.EntityFrameworkCore;
using Repository.IRepository;
using Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.RepositoryService
{
    public class EmployeeService : IEmployee
    {

        public async Task<ResponseModel> GetAllEmployeeInfo()
        {
            ResponseModel objResponseModel = new ResponseModel();
            using (var DbContext = new AppslabHrDBContext())
            {
                List<Employee> EmployeeList = new List<Employee>();
                EmployeeList = await DbContext.Employee.ToListAsync();
                objResponseModel.Data = EmployeeList;
                return objResponseModel;
            }
            
        }


    }
}
