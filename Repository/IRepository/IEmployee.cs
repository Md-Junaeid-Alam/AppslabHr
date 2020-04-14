using Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.IRepository
{
    public interface IEmployee
    {
         Task<ResponseModel> GetAllEmployeeInfo();
    }
}
