using MediatorAkademiPlusPostgre.MediatorDesignPattern.Results;
using MediatR;

namespace MediatorAkademiPlusPostgre.MediatorDesignPattern.Queries
{
    public class GetAllProductQuery:IRequest<List<GetAllProductQueryResult>>
    { 
    }
}
