using MediatorAkademiPlusPostgre.DAL;
using MediatR;

namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Commands
{
    public class CreateProductCommand:IRequest
    {
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public int CategoryID { get; set; }
    }
}
