using Microsoft.AspNetCore.Mvc;
using Web_API_Vesioning.API.Model.DTOs;

namespace Web_API_Vesioning.API.V2.Controllers
{
    [Route("api/v2/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var contriesDomailModel = CountriesData.Get();
            var response = new List<CountryDtoV2>();
            foreach (var countryDomain in contriesDomailModel)
            {
                response.Add(new CountryDtoV2
                {
                    Id = countryDomain.Id,
                    CountryName = countryDomain.Name,
                });
            }
            return Ok(response);
        }
    }
}
