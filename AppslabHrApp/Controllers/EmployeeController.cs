using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository.IRepository;
using Response;

namespace AppslabHrApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _Employee;
        public EmployeeController(IEmployee Employee)
        {
            _Employee = Employee;
        }

        [HttpGet]
        public async Task<ResponseModel> GetAllEmpleeList()
        {
            ResponseModel objResponseModel = new ResponseModel();

            objResponseModel = await _Employee.GetAllEmployeeInfo();
            return objResponseModel;

        }


    }
}