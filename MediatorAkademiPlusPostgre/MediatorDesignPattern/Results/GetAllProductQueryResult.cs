namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Results
{
    public class GetAllProductQueryResult
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? ProductBrand { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
