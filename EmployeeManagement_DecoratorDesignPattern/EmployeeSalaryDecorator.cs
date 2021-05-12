using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement_DecoratorDesignPattern
{
    public class EmployeeSalaryDecorator:IEmployeeSalary
    {
        private IEmployeeSalary _employeeSalary;

        public EmployeeSalaryDecorator(IEmployeeSalary employeeSalary)
        {
            this._employeeSalary = employeeSalary;
        }

        public virtual double GetSalary()
        {
            return this._employeeSalary.GetSalary();
        }
    }
}
