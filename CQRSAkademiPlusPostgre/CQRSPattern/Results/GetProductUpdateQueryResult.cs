namespace CQRSAkademiPlusPostgre.CQRSPattern.Results
{
    public class GetProductUpdateQueryResult
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public string ProductCategory { get; set; }
        public int ProductStock { get; set; }
        public string ProductStockType { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal Tax { get; set; }
        public string Publisher { get; set; }
        public DateTime LastUseDate { get; set; }
        public string Barcode { get; set; }
        public string ShelfNumber { get; set; }
    }
}
