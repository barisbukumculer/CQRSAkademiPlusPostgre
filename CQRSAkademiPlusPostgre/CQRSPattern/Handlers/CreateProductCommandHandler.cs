using CQRSAkademiPlusPostgre.CQRSPattern.Commands;
using CQRSAkademiPlusPostgre.Dal;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class CreateProductCommandHandler
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateProductCommand command)
        {
            _context.Products.Add(new Product
            {
                ProductName = command.ProductName,
                ProductBrand = command.ProductBrand,
                ProductCategory = command.ProductCategory,
                ProductPrice = command.ProductPrice,
                ProductStock = command.ProductStock,
                ProductStockType = command.ProductStockType,
                Publisher = command.Publisher,
                Barcode = command.Barcode,
                LastUseDate = command.LastUseDate,
                ShelfNumber = command.ShelfNumber,
                Tax = command.Tax,
            });
            _context.SaveChanges();
        }
    }
}
