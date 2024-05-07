using Microsoft.AspNetCore.Mvc;
using TestWebAPI.Models;

namespace TestWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // [EnableCors]
    public class DataController : ControllerBase
    {
        [HttpPost, Route("processData")]
        public IActionResult ProcessData([FromBody] DataModel data) 
        {
            // Process the data (perform some action)
            var result = "Hello, " + data.Name;

            // Return the result
            return Ok( new { result });
        }
    }
}
