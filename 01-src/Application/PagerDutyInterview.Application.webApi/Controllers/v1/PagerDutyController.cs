using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Application.WebApi.Controllers.v1
{
    [ApiController]
    [Route("v1/[controller]")]
    public class PagerDutyController : ControllerBase
    {
        private readonly IPagerDutyService _service;

        public PagerDutyController(IPagerDutyService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string param1, [FromQuery] string param2)
        {
            var result = param1;

            if(result is not null)
            {
                return Ok(result);
            }

            return NotFound();
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = id;

            if (result != default)
            {
                return Ok(result);
            }

            return NotFound();
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] object request)
        {
            var result = request;

            return new ObjectResult(result) { StatusCode = StatusCodes.Status201Created };
        }
    }
}

