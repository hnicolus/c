using coding;
// loop over all employees
// every employee , call method to call calculate amount given hours,
//Contact employees are paid by the hour and permanent employees are paid a fixed amount

List<Employee> employees = new();

Employee contractEmployee = new();
Employee permanentEmployee = new();

employees.Add(contractEmployee);
employees.Add(permanentEmployee);

contractEmployee.SetSalaryCalculator(new ContractEmployeeCalculator(hourlyRate: 100, hoursWorked: 8));
permanentEmployee.SetSalaryCalculator(new PermanentEmployeeSalaryCalculator(salary: 1000));

foreach (Employee employee in employees)
{
    Console.WriteLine(employee.CalculateSalary());
}