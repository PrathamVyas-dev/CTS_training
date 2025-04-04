using Microsoft.AspNetCore.Mvc;
using HelloWorld_A.model;
namespace HelloWorld_A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MathController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] MathParameters parameters)
        {
            if (parameters == null)
            {
                return BadRequest("Invalid parameters.");
            }

            var result = new MathResult
            {
                Addition = parameters.Add(),
                Subtraction = parameters.Subtract(),
                Multiplication = parameters.Multiply(),
                Division = parameters.secondnumber != 0 ? parameters.Divide() : double.NaN
            };

            return Ok(result);
        }
    }
}
