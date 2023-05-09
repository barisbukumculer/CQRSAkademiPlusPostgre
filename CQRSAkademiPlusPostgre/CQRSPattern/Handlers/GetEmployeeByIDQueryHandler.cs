using CQRSAkademiPlusPostgre.CQRSPattern.Queries;
using CQRSAkademiPlusPostgre.CQRSPattern.Results;
using CQRSAkademiPlusPostgre.Dal;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class GetEmployeeByIDQueryHandler
    {
        private readonly Context _context;

        public GetEmployeeByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetEmployeeByIDQueryResult Handle(GetEmployeeByIDQuery query)
        {
            var values = _context.Employees.Find(query.Id);
            return new GetEmployeeByIDQueryResult
            {
                EmployeeCity = values.EmployeeCity,
                EmployeeID = values.EmployeeID,
                EmployeeName = values.EmployeeName,
                EmployeeSurname = values.EmployeeSurname
            };
        }
    }
}
