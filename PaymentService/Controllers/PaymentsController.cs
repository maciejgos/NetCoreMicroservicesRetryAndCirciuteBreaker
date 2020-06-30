using Microsoft.AspNetCore.Mvc;

namespace PaymentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        public IActionResult Post([FromBody] PaymentRequest request)
        {
            return new OkResult();
        }

        public class PaymentRequest
        {
            public double Amount { get; set; }
        }
    }
}
