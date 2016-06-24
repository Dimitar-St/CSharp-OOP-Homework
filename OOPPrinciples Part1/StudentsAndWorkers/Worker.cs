namespace StudentsAndWorkers
{
    public class Worker : Human
    {

        public Worker (string fName, string lName, int weekSalary, int workHoursPerDay) : base(fName, lName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public int WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public double MoneyPerHour()
        {
            var result = this.WeekSalary / (this.WorkHoursPerDay * 5);

            return result;
        }
    }
}
