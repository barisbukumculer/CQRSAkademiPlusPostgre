using CQRSAkademiPlusPostgre.CQRSPattern.Queries;
using CQRSAkademiPlusPostgre.CQRSPattern.Results;
using CQRSAkademiPlusPostgre.Dal;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class GetEmployeeUpdateByIDQueryHandler
    {
        private readonly Context _context;
        public GetEmployeeUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetEmloyeeUpdateQueryResult Handle(GetEmployeeUpdateByIDQuery query)
        {
            var values = _context.Employees.Find(query.Id);
            return new GetEmloyeeUpdateQueryResult
            {
                EmployeeAge = values.EmployeeAge,
                EmployeeCity = values.EmployeeCity,
                EmployeeID = values.EmployeeID,
                EmployeeName = values.EmployeeName,
                EmployeeSalary = values.EmployeeSalary,
                EmployeeSurname = values.EmployeeSurname,
                EmployeeTitle = values.EmployeeTitle
            };
        }
    }
}
