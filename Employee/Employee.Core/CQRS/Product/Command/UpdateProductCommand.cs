using AutoMapper;
using Employee.Core.CQRS.Country.Command;
using Employee.Model;
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

namespace Employee.Core.CQRS.Product.Command
{
    public record UpdateProductCommand(int Id, VMProduct product) : IRequest<CommandResult<VMProduct>>;

    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, CommandResult<VMProduct>>
    {

        private readonly IProductRepository _productRepository;
        
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<CommandResult<VMProduct>> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var data = _mapper.Map<Products>(request.product);
            var result = await _productRepository.UpdateAsync(request.Id, data);
            return result switch
            {
                null => new CommandResult<VMProduct>(null, CommandResultTypeEnum.UnprocessableEntity),
                _ => new CommandResult<VMProduct>(result, CommandResultTypeEnum.Success)
            };
        }
    }
}
