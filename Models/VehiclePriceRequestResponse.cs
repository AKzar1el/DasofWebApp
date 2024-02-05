using DasofWebApp.Common.Attributes;
using System.ComponentModel.DataAnnotations;

namespace DasofWebApp.Models
{
    // Class for the VehiclePrice request and response
    public class VehiclePriceRequest
    {
        [Required]
        [PositiveNumber]
        public decimal Vat { get; set; }

        [PositiveNumber]
        public decimal BasePriceNet { get; set; }

        [PositiveNumber]
        public decimal BasePriceGross { get; set; }

        [PositiveNumber]
        public decimal AdditionalEquipmentPriceNet { get; set; }

        [PositiveNumber]
        public decimal AdditionalEquipmentPriceGross { get; set; }
    }

    public class VehiclePriceResponse
    {
        public decimal BasePriceNet { get; set; }
        public decimal BasePriceGross { get; set; }
        public decimal AdditionalEquipmentPriceNet { get; set; }
        public decimal AdditionalEquipmentPriceGross { get; set; }
        public decimal TotalPriceNet => AdditionalEquipmentPriceNet + BasePriceNet;
        public decimal TotalPriceGross => AdditionalEquipmentPriceGross + BasePriceGross;
    }
}