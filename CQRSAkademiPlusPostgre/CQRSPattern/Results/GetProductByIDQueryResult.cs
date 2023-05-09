namespace CQRSAkademiPlusPostgre.CQRSPattern.Results
{
    public class GetProductByIDQueryResult
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public string ProductCategory { get; set; }
        public int ProductStock { get; set; }
    }
}
