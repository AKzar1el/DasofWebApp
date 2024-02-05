using DasofWebApp.Models;

namespace DasofWebApp.Services.VehiclePriceService
{
    public class VehiclePriceService : IVehiclePriceService
    {
        // Calculates the vehicle price
        public VehiclePriceResponse GetVehiclePrice(VehiclePriceRequest request)
        {
            var response = new VehiclePriceResponse();
            // Calculates the Vat ratio
            var vatRate = request.Vat / 100;

            response.BasePriceNet = request.BasePriceNet;
            // Checks if BasePriceNet parameter was given
            if (request.BasePriceNet <= 0)
            {// If given sets the BasePriceNet by converting the base price gross to net value
                response.BasePriceNet = CalculatePriceGrossToNet(request.BasePriceGross, vatRate);
                response.BasePriceGross = request.BasePriceGross;
            }
            else
            {// If not given sets BasePriceGross by converting the base price net to gross
                response.BasePriceGross = CalculatePriceNetToGross(request.BasePriceNet, vatRate);
            }

            response.AdditionalEquipmentPriceNet = request.AdditionalEquipmentPriceNet;
            // Checks if BasePriceNet parameter was given
            if (request.AdditionalEquipmentPriceNet <= 0)
            {
                response.AdditionalEquipmentPriceNet = CalculatePriceGrossToNet(request.AdditionalEquipmentPriceGross, vatRate);
                response.AdditionalEquipmentPriceGross = request.AdditionalEquipmentPriceGross;
            }
            else
            {
                response.AdditionalEquipmentPriceGross = CalculatePriceNetToGross(request.AdditionalEquipmentPriceNet, vatRate);
            }

            return response;
        }

        // Helpers
        public decimal CalculatePriceGrossToNet(decimal price, decimal vatRate)
        {
            return price / (1 + vatRate);
        }

        public decimal CalculatePriceNetToGross(decimal price, decimal vatRate)
        {
            return (price * vatRate) + price;
        }
    }
}