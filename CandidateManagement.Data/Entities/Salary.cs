using CandidateManagement.Data.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CandidateManagement.Data.Entities
{
    public class Salary
    {
        public int SalaryId { get; set; }
        public int BrutoWage { get; set; }
        public int NettoWage { get; set; }
        public int? CompanyCarId { get; set; }
        public CompanyCar CompanyCar { get; set; }
        public int DailyAllowance { get; set; }
        public bool HasMealVouchers { get; set; }
        public int MealVoucherValue { get; set; }
        public bool HasHospitalityInsurance { get; set; }
        public int HospitalityInsurance { get; set; }
        public bool HasGroupsInsurance { get; set; }
        public int GroupsInsurance { get; set; }
    }
}
