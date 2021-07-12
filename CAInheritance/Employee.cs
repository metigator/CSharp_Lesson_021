using System;

namespace CAInheritance
{
    public class Employee
    {
        public const int MinimumLoggedHours = 176;
        public const decimal OverTimeRate = 1.25m;

        protected Employee(int id, string name, decimal loggedHours, decimal wage)
        {
            Id = id;
            Name = name;
            LoggedHours = loggedHours;
            Wage = wage;
        }

        protected int Id { get; set; }

        protected string Name { get; set; }

        protected decimal LoggedHours { get; set; }

        protected decimal Wage { get; set; }


        protected virtual decimal Calculate()
        {
            return CalculateBaseSalary() + CalculateOverTime();
        }

        private decimal CalculateBaseSalary()
        {
            return  LoggedHours * Wage ;
        }
        private decimal CalculateOverTime()
        {
            var additionalHours = ((LoggedHours - MinimumLoggedHours) > 0 ? LoggedHours - MinimumLoggedHours : 0);

            return additionalHours * Wage * OverTimeRate;
        }
        public override string ToString()
        {
            var type = GetType().ToString().Replace("CAInheritance.", ""); 
            return $"{type}"+
                   $"\nId: {Id}" +
                   $"\nName: {Name}" +
                   $"\nLogged Hours: {LoggedHours} hrs" +
                   $"\nWage: {Wage} $/hr" +
                   $"\nBase Salary: ${Math.Round(CalculateBaseSalary(),2):N0}" +
                   $"\nOvertime: ${Math.Round(CalculateOverTime(), 2):N0}";
                    

        }
    }

    
}
