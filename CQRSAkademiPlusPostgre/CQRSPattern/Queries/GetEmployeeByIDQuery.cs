namespace CQRSAkademiPlusPostgre.CQRSPattern.Queries
{
    public class GetEmployeeByIDQuery
    {
        public GetEmployeeByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
