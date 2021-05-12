using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement_DecoratorDesignPattern
{
    public class ContractEmployee : IEmployeeSalary
    {
        public double GetSalary()
        {
            return 5000;
        }
    }
}
