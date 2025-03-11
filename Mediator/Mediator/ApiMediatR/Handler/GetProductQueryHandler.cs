using ApiMediatR.QueryCommands;
using ApiMediatR.Model;
using MediatR;

namespace ApiMediatR.Handler
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, Product>
    {

        public Task<Product> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            //simulate the fetching of product
            var product = new Product
            {
                Id = 1,
                Name = "Product 1",
                Price = 100
            };
            return Task.FromResult(product);
        }
    }
}
