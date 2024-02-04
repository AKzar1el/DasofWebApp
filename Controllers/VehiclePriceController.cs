using DasofWebApp.Models;
using DasofWebApp.Services.VehiclePriceService;
using Microsoft.AspNetCore.Mvc;

namespace DasofWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclePriceController : ControllerBase
    {
        private readonly IVehiclePriceService _vehiclePriceService;
        public VehiclePriceController(IVehiclePriceService vehiclePriceService)
        {
            // Injects the service, that contains functions for calculating vehicle price
            _vehiclePriceService = vehiclePriceService;
        }

        [HttpPost]
        public ActionResult<VehiclePrice> GetVehiclePrice(VehiclePrice vehiclePrice)
        {// Returns the calculated prices for vehicle
            return Ok(_vehiclePriceService.GetVehiclePrice(vehiclePrice));
        }//TODO: If return null
    }
}
