namespace CQRSAkademiPlusPostgre.CQRSPattern.Commands
{
    public class UpdateEmployeeCommand
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeeTitle { get; set; }
        public int EmployeeAge { get; set; }
        public string EmployeeCity { get; set; }
        public decimal EmployeeSalary { get; set; }
    }
}
