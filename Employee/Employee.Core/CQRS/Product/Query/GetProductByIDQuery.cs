using Employee.Core.CQRS.Country.Query;
using Employee.Repository.Concrete;
using Employee.Repository.Interface;
using Employee.Service.Model;
using Employee.Shared.Models;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.CQRS.Product.Query;

public record GetProductByIDQuery(int Id) : IRequest<QueryResult<VMProduct>>;

public class GetProductByIDQueryHandler : IRequestHandler<GetProductByIDQuery, QueryResult<VMProduct>>
{
    private readonly IProductRepository _productRepository;

    public GetProductByIDQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    //private readonly IValidator<GetAllCountryByIDQuery> _validator;
    public async Task<QueryResult<VMProduct>> Handle(GetProductByIDQuery request, CancellationToken cancellationToken)
    {
        
        var product = await _productRepository.GetByIdAsync(request.Id);
        return product switch
        {
            null => new QueryResult<VMProduct>(null, QueryResultTypeEnum.NotFound),
            _ => new QueryResult<VMProduct>(product, QueryResultTypeEnum.Success)
        };
    }
}

