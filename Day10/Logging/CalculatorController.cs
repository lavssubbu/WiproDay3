using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoggingDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("add")]
        public IActionResult AddNumbers(int a, int b)
        {
            //_logger.LogInformation("AddNumbers method called with {A} and {B}", a, b);

            //// Create Calculator instance
            //Calculator calculator = new Calculator();

            //// Call Add method
            //int result = calculator.Add(a, b);

            //return Ok(new { Sum = result });

            _logger.LogInformation("AddNumbers endpoint called with a = {A}, b = {B}", a, b);

            try
            {
                // Add some basic validation and warnings
                if (a < 0 || b < 0)
                {
                    _logger.LogWarning("One or both parameters are negative: a = {A}, b = {B}", a, b);
                }

                Calculator calculator = new Calculator();
                int result = calculator.Add(a, b);

                _logger.LogInformation("Addition successful. Result = {Result}", result);

                return Ok(new { Sum = result });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while adding numbers {A} and {B}", a, b);
                return StatusCode(500, "An internal server error occurred.");
            }
        }
    }
}
