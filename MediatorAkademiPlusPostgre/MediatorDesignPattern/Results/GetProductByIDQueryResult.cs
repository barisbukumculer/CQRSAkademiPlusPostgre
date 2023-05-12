using MediatorAkademiPlusPostgre.DAL;

namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Results
{
    public class GetProductByIDQueryResult
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public int CategoryID { get; set; }
    }
}
