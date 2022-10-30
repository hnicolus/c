namespace coding
{
    public class PermanentEmployeeSalaryCalculator : ISalaryCalculator
    {
        private readonly decimal salary = decimal.MinValue;

        public PermanentEmployeeSalaryCalculator(decimal salary = 1000)
        {
            this.salary = salary;
        }

        public decimal CalculateSalary()
        {
            return salary;
        }
    }
}