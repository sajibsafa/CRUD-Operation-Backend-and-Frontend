using Employee.Core.CQRS.Country.Query;
using Employee.Repository.Concrete;
using Employee.Repository.Interface;
using Employee.Service.Model;
using Employee.Shared.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.CQRS.Product.Query;

public record GetAllProductQuery: IRequest<QueryResult<IEnumerable<VMProduct>>>;

public class GetAllProductQueryHander : IRequestHandler<GetAllProductQuery, QueryResult<IEnumerable<VMProduct>>>
{
    private readonly IProductRepository _productRepository;

    public GetAllProductQueryHander(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<QueryResult<IEnumerable<VMProduct>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
    {
        var product = await _productRepository.GetAllAsync();
        return product switch
        {
            null => new QueryResult<IEnumerable<VMProduct>>(null, QueryResultTypeEnum.NotFound),
            _ => new QueryResult<IEnumerable<VMProduct>>(product, QueryResultTypeEnum.Success)
        };
    }
}

