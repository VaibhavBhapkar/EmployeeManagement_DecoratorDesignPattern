using System;

namespace EmployeeManagement_DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployeeSalary basicEmployeeSalary = new PermanentEmployee();   
            EmployeeSalaryDecorator basicEmployeeSalaryDecorator = new PermenentEmployeeWithBasicPackage(basicEmployeeSalary);
            Console.WriteLine(basicEmployeeSalaryDecorator.GetSalary());
            IEmployeeSalary basicContractEmployeeSalary = new ContractEmployee();
            EmployeeSalaryDecorator basicContractEmployeeSalaryDecorator = new ContractEmployeeWithBasicPackage(basicContractEmployeeSalary);
            Console.WriteLine(basicContractEmployeeSalaryDecorator.GetSalary());
        }
    }
}
