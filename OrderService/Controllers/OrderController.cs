using Microsoft.AspNetCore.Mvc;
using OrderService.Services;
using System.Threading.Tasks;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IPaymentService _paymentService;

        public OrderController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OrderDto order)
        {
            // Some logic to place an order
            var response = await _paymentService.MakePayment(new PaymentRequest { Amount = 100.25 });
            if (response.Status == "Success")
                return new OkResult();
            else
                return new OkObjectResult("Unable to process payment");
        }
    }

    public class OrderDto
    {
        public string Name { get; set; }
    }
}
