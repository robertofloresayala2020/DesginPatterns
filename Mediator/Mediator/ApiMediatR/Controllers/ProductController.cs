using Microsoft.AspNetCore.Mvc;
using MediatR;
using ApiMediatR.Command;

namespace ApiMediatR.Controllers
{
    [ApiController]
    [Route("api/controller")]
    public class ProductController : ControllerBase
    {

        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody]CreateProductCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var query = new GetProductQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

    }
}
