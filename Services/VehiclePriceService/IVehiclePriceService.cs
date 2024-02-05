using DasofWebApp.Models;

namespace DasofWebApp.Services.VehiclePriceService
{
    // Interface for VehiclePriceService
    public interface IVehiclePriceService
    {
        // Calculates the vehicle price
        VehiclePriceResponse GetVehiclePrice(VehiclePriceRequest request);
    }
}
