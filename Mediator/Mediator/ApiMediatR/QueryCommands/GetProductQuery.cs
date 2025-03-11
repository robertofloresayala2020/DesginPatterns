using ApiMediatR.Model;
using MediatR;

namespace ApiMediatR.QueryCommands
{
    public class GetProductQuery : IRequest<Product>
    {
    
         public int ProductId { get; set; }

        public GetProductQuery(int productId)
        {
            ProductId = productId;
        }
    }
}
