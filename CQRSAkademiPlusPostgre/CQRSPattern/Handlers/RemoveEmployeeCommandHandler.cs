using CQRSAkademiPlusPostgre.CQRSPattern.Commands;
using CQRSAkademiPlusPostgre.Dal;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class RemoveEmployeeCommandHandler
    {
       private readonly Context _context;

        public RemoveEmployeeCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(RemoveEmployeeCommand command)
        {
            var values = _context.Employees.Find(command.Id);
            _context.Employees.Remove(values);
            _context.SaveChanges();
        }
    }
}
