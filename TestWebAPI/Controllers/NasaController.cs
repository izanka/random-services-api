using Microsoft.AspNetCore.Mvc;

namespace RandomServicesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NasaController : ControllerBase
    {
        HttpClient _httpClient = new HttpClient();

        public NasaController(HttpClient httpClient) {
            _httpClient = httpClient;
        }

        [HttpGet("getImageOfTheDay")]
        public async Task<IActionResult> GetImageOfTheDay()
        {
            var url = "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?sol=1000&camera=fhaz&api_key=DEMO_KEY"; 

            var response = await _httpClient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var content = response.Content.ReadAsStringAsync();
                return Ok(content);
            }
            else {
                return StatusCode((int)response.StatusCode);
            }
        }
    }
}
