using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Application.WebApi.Controllers.v1
{
    [ApiController]
    [Route("v1/[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _service;
        public CountryController(ICountryService service)
        {
            _service = service;
        }

        [HttpGet("{name}", Name = "Country")]
        public async Task<IActionResult> Get([FromRoute] string name)
        {
            var result = await _service.Get(name);

            if(result.Any())
            {
                return Ok(result);
            }

            return NotFound();
        }
    }
}

