using DasofWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DasofWebApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiclePriceController
    {
        [HttpPost]
        public ActionResult<VehiclePrice> GetVehiclePrice(VehiclePrice vehiclePrice)
        {
            throw new NotImplementedException();
        }
    }
}
