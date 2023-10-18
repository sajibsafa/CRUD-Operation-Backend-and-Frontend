using Employee.Core.CQRS.Country.Command;
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

namespace Employee.Core.CQRS.Product.Command
{
    public record DeleteProductCommand(int Id) : IRequest<CommandResult<VMProduct>>;

    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, CommandResult<VMProduct>>
    {
        private readonly IProductRepository _productRepository;

        public DeleteProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<CommandResult<VMProduct>> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var result = await _productRepository.DeleteAsync(request.Id);
            return result switch
            {
                null => new CommandResult<VMProduct>(null, CommandResultTypeEnum.NotFound),
                _ => new CommandResult<VMProduct>(result, CommandResultTypeEnum.Success)
            };
        }
    }
}