namespace CQRSAkademiPlusPostgre.CQRSPattern.Commands
{
    public class RemoveEmployeeCommand
    {
        public RemoveEmployeeCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
