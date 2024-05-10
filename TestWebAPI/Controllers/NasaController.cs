using Microsoft.AspNetCore.Mvc;

namespace RandomServicesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NasaController : ControllerBase
    {
        public IActionResult GetImageOfTheDay()
        {
            var url = "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?sol=1000&camera=fhaz&api_key=DEMO_KEY";
            HttpClient client = new HttpClient();

            var response = client.GetAsync(url);

            return Ok();
        }
    }
}
