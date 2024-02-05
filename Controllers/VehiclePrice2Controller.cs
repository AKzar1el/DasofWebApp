using DasofWebApp.Models;
using DasofWebApp.Services.VehiclePriceService;
using Microsoft.AspNetCore.Mvc;

namespace DasofWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclePrice2Controller : ControllerBase
    {
        private readonly IVehiclePriceService _vehiclePriceService;

        public VehiclePrice2Controller(IVehiclePriceService vehiclePriceService)
        {
            // Injects the service, that contains functions for calculating vehicle price
            _vehiclePriceService = vehiclePriceService;
        }

        [HttpPost("GetVehiclePrice")]
        public ActionResult<VehiclePriceResponse> GetVehiclePrice([FromBody] VehiclePriceRequest request)
        {// Returns the calculated prices for vehicle
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var response = _vehiclePriceService.GetVehiclePrice(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}