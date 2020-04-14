using System;
using System.Collections.Generic;

namespace EntityModel.EntityModels
{
    public partial class Employee
    {
        public int? Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public Guid? EmployeeUniqueCode { get; set; }
        public int? EmployeeAge { get; set; }
        public double? EmployeeSalary { get; set; }
    }
}
