using DasofWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DasofWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclePriceController : ControllerBase
    {
        [HttpPost("GetVehiclePrice")]
        public ActionResult<VehiclePrice> GetVehiclePrice([FromBody] VehiclePrice vehiclePrice)
        {// Returns the calculated prices for vehicle
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return Ok(vehiclePrice);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}