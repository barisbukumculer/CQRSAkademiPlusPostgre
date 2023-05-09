using CQRSAkademiPlusPostgre.CQRSPattern.Queries;
using CQRSAkademiPlusPostgre.CQRSPattern.Results;
using CQRSAkademiPlusPostgre.Dal;

namespace CQRSAkademiPlusPostgre.CQRSPattern.Handlers
{
    public class GetProductByIDQueryHandler
    {
        private readonly Context _context;

        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }
        public GetProductByIDQueryResult Handle(GetProductByIDQuery query)
        {
            var values = _context.Products.Find(query.Id);
            return new GetProductByIDQueryResult
            {
                ProductID = values.ProductID,
                ProductName = values.ProductName,
                ProductBrand = values.ProductBrand,
                ProductCategory = values.ProductCategory,
                ProductStock = values.ProductStock
            };
        }
    }
}
