using CommisionCalculator.Application.UseCases.Sales.Calculate;
using CommisionCalculator.Communication.Requests;
using CommisionCalculator.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CommisionCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseSales), StatusCodes.Status200OK)]
        public IActionResult Register(
            [FromServices] ICalculateCommisionUseCase useCase,
            [FromBody] RequestSales request)
        {
            var response = useCase.Execute(request.Sales);
            return Ok(response);
        }
    }
}
