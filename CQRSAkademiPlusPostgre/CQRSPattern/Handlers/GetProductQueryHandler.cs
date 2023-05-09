using CQRSAkademiPlusPostgre.CQRSPattern.Results;
using CQRSAkademiPlusPostgre.Dal;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                ProductBrand = x.ProductBrand,
                ProductName = x.ProductName,
                ProductCategory = x.ProductCategory,
                ProductID = x.ProductID,
                ShelfNumber = x.ShelfNumber,
                LastUseDate = x.LastUseDate,
                Barcode = x.Barcode,
                ProductPrice = x.ProductPrice,
                ProductStock = x.ProductStock,
                ProductStockType = x.ProductStockType,
                Publisher = x.Publisher,
                Tax = x.Tax,
            }).ToList();
            return values;
        }
    }
}
