using CQRSAkademiPlusPostgre.CQRSPattern.Commands;
using CQRSAkademiPlusPostgre.Dal;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class UpdateEmployeeCommandHandler
    {
        private readonly Context _context;

        public UpdateEmployeeCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateEmployeeCommand command) 
        {
            var values = _context.Employees.Find(command.EmployeeID);
            values.EmployeeSurname = command.EmployeeSurname;
            values.EmployeeSalary = command.EmployeeSalary;
            values.EmployeeName = command.EmployeeName;
            values.EmployeeName =command.EmployeeName;
            values.EmployeeAge = command.EmployeeAge;
            values.EmployeeTitle = command.EmployeeTitle;
            _context.SaveChanges();
        }
    }
}
