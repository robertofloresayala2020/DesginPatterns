using MediatR;

namespace ApiMediatR.Command
{
    public class CreateProductCommand : IRequest<int>
    {

         public string Name { get; set; }

        public decimal Price { get; set; }

        public CreateProductCommand(string name , decimal price)
        {
            Name = name;
            Price = price;  
        }


    }
}
