namespace ApiMediatR.Command
{
    public class GetProductQuery
    {

        public int ProductId { get; set; }

        public GetProductQuery(int productId)
        {
            ProductId = productId;
        }
    }
}
