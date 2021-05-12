using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement_DecoratorDesignPattern
{
    public class PermanentEmployee : IEmployeeSalary
    {
        public double GetSalary()
        {
            return 10000;
        }
    }
}
