
using Infrastructure.Enums;

namespace Infrastructure.Employee
{
    public class Employee
    {
        public int Id { get; set; }
        public double Balance { get; set; }
        public double ToDayBalance { get; set; }
        public double BalanceOfTheMonth { get; set; }
        public double BalanceAllTime { get; set; }
        public EmployeeState EmployeeState { get; set; }




    }
}
