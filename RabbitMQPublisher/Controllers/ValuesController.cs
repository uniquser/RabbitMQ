using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RabbitMQPublisher.Factory;

namespace RabbitMQPublisher.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        RabbitMQService? rabbitMQ;
        [HttpPost("addproduct")]
        public IActionResult AddProduct(string product)
        {
            rabbitMQ = new RabbitMQService();
            rabbitMQ.GetRabbitMQConnection(product);

            return Ok();
        }
    }
}
