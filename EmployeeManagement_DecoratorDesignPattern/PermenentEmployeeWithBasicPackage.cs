using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement_DecoratorDesignPattern
{
    public class PermenentEmployeeWithBasicPackage:EmployeeSalaryDecorator
    {
        public PermenentEmployeeWithBasicPackage(IEmployeeSalary employeeSalary) : base(employeeSalary)
        {

        }
        public override double GetSalary()
        {
            return base.GetSalary() + 2000;
        }
    }
}
