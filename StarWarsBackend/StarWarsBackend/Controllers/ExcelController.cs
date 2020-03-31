using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using GemBox.Spreadsheet;
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
            var options = SaveOptions.XlsxDefault;
            var noSpaceName = Regex.Replace(person.Name, @"s", "");
            var fileName = noSpaceName + "profile.xlsx";
            var excelDocument = new Excel(person);
            return File(excelDocument.Create(), options.ContentType, fileName);
        }
    }
}