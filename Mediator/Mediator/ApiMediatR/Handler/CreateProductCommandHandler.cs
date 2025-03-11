using ApiMediatR.Command;
using ApiMediatR.Model;
using MediatR;

namespace ApiMediatR.Controllers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {

        public Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {

            var newProduct = new Product
            {
                Name = request.Name,
                Price = request.Price
            };  
            //simulate the creation of product
            return Task.FromResult(1);

        }
    }
}
