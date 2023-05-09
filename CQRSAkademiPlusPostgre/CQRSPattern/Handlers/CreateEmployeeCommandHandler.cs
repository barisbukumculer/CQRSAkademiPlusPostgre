using CQRSAkademiPlusPostgre.CQRSPattern.Commands;
using CQRSAkademiPlusPostgre.Dal;
using Newtonsoft.Json.Bson;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class CreateEmployeeCommandHandler
    {
        private readonly Context _context;

        public CreateEmployeeCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateEmployeeCommand command)
        {
            _context.Employees.Add(new Employee
            {
                EmployeeAge = command.EmployeeAge,
                EmployeeCity = command.EmployeeCity,
                EmployeeName = command.EmployeeName,
                EmployeeSalary = command.EmployeeSalary,
                EmployeeSurname = command.EmployeeSurname,
                EmployeeTitle = command.EmployeeTitle
            });
            _context.SaveChanges();
        }
    }
}
