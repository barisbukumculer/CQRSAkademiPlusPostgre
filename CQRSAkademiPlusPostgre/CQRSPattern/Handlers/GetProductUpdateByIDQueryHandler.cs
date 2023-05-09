using CQRSAkademiPlusPostgre.CQRSPattern.Queries;
using CQRSAkademiPlusPostgre.CQRSPattern.Results;
using CQRSAkademiPlusPostgre.Dal;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class GetProductUpdateByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductUpdateByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductUpdateQueryResult Handle(GetProductUpdateByIDQuery query)
        {
            var values = _context.Products.Find(query.Id);
            return new GetProductUpdateQueryResult
            {
                ProductBrand = values.ProductBrand,
                ProductName = values.ProductName,
                ProductCategory = values.ProductCategory,
                ProductPrice = values.ProductPrice,
                ProductStock = values.ProductStock,
                ProductStockType = values.ProductStockType,
                Publisher = values.Publisher,
                ProductID = values.ProductID,
                Barcode = values.Barcode,
                LastUseDate = values.LastUseDate,
                ShelfNumber = values.ShelfNumber,
                Tax = values.Tax
            };
        }
    }
}
