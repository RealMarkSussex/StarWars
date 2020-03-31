using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StarWarsBackend.Models;

namespace StarWarsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExcelController : ControllerBase
    {
        [HttpPost]
        public IActionResult Get([FromBody] Person person)
        {
            if(person == null)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}