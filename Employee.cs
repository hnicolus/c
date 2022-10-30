
//
// llop over all employees
//for every employee , call method to call claculate amount given hours,

using System.Diagnostics.CodeAnalysis;

namespace coding
{

    public class Employee
    {
        private ISalaryCalculator salaryCalculator;

        public void SetSalaryCalculator([NotNull] ISalaryCalculator salaryCalculator)
        {
            this.salaryCalculator = salaryCalculator;
        }

        public decimal CalculateSalary()
        {
            return salaryCalculator.CalculateSalary();
        }
    }
}