using MediatorAkademiPlusPostgre.DAL;
using MediatorAkademiPlusPostgre.MediatorDesignPattern.Queries;
using MediatorAkademiPlusPostgre.MediatorDesignPattern.Results;
using MediatR;
using NuGet.Protocol.Plugins;

namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Handlers
{
    public class GetProductByIDQueryHandler : IRequestHandler<GetProductByIDQuery, GetProductByIDQueryResult>
    {
        private readonly Context _context;

        public GetProductByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductByIDQueryResult> Handle(GetProductByIDQuery request, CancellationToken cancellationToken)
        {
            var values=await _context.Products.FindAsync(request.Id);
            return new GetProductByIDQueryResult
            {
                CategoryID = values.CategoryID,
                ProductBrand = values.ProductBrand,
                ProductName = values.ProductName,
                ProductID = values.ProductID,
                ProductPrice = values.ProductPrice,
                ProductStock = values.ProductStock
            };
        }
    }
}
