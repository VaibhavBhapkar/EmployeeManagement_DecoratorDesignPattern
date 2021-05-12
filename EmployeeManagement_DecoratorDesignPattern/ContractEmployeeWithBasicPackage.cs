using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement_DecoratorDesignPattern
{
    public class ContractEmployeeWithBasicPackage:EmployeeSalaryDecorator
    {
        public ContractEmployeeWithBasicPackage(IEmployeeSalary employeeSalary) : base(employeeSalary)
        {

        }
        public override double GetSalary()
        {
            return base.GetSalary() + 1000;
        }
    }
}
