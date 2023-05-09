namespace CQRSAkademiPlusPostgre.CQRSPattern.Queries
{
    public class GetEmployeeUpdateByIDQuery
    {
        public GetEmployeeUpdateByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
