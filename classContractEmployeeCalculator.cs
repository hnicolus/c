
//
// llop over all employees
//for every employee , call method to call claculate amount given hours,

namespace coding
{


    public class ContractEmployeeCalculator : ISalaryCalculator
    {
        private readonly int hourlyRate = int.MinValue;
        private readonly int hoursWorked = int.MinValue;

        public ContractEmployeeCalculator(int hourlyRate, int hoursWorked)
        {
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }

        public decimal CalculateSalary()
        {
            return hourlyRate * hoursWorked;
        }
    }
}