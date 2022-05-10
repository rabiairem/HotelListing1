using HotelListing.Data;
using Microsoft.AspNetCore.Mvc;

namespace HotelListing.Controllers
{
    [ApiVersion("2.0", Deprecated = true)]
    //one way
    //[Route("api/{v:apiversion}/country")]
    [Route("api/country")]
    [ApiController]
    public class CountryV2Controller : ControllerBase
    {
        //Normally we don't want to access db directly
        private DataBaseContext _context;

        public CountryV2Controller(DataBaseContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCountries()
        {
            return Ok(_context.Countries);
        }
    }
}
