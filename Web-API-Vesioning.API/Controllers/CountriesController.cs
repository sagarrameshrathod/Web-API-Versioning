using Microsoft.AspNetCore.Mvc;
using Web_API_Vesioning.API.Model.DTOs;

namespace Web_API_Vesioning.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var contriesDomailModel = CountriesData.Get();
            var response = new List<CountryDto>();
            foreach (var countryDomain in contriesDomailModel)
            {
                response.Add(new CountryDto
                {
                    Id = countryDomain.Id,
                    Name = countryDomain.Name,
                });
            }
            return Ok(response);
        }
    }
}
