using CQRSAkademiPlusPostgre.CQRSPattern.Results;
using CQRSAkademiPlusPostgre.Dal;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class GetEmployeeQueryHandler
    {
        private readonly  Context _context;

        public GetEmployeeQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetEmployeeQueryResult> Handle()
        {
            var values = _context.Employees.Select(x => new GetEmployeeQueryResult
            {
                EmployeeAge = x.EmployeeAge,
                EmployeeName = x.EmployeeName,
                EmployeeCity = x.EmployeeCity,
                EmployeeID = x.EmployeeID,
                EmployeeSalary = x.EmployeeSalary,
                EmployeeSurname = x.EmployeeSurname,
                EmployeeTitle = x.EmployeeTitle
            }).ToList();
            return values;
        }
    }
}
