using DasofWebApp.Common.Attributes;
using System.ComponentModel.DataAnnotations;

namespace DasofWebApp.Models
{
    // Class for calculating vehicle price
    public class VehiclePrice
    {
        // Proprety for field VAT rate
        private decimal _vat;

        [Required]
        [PositiveNumber]
        public decimal Vat
        {// Returns vat rate e.g. 22 % => 0.22
            get { return (_vat / 100); }
            set => _vat = value;
        }

        // Proprety for field Base vehicle price
        [PositiveNumber]
        public decimal BasePriceNet { get; set; } = 0;

        private decimal _basePriceGross;

        [PositiveNumber]
        public decimal BasePriceGross
        {
            get
            {// Checks if BasePriceNet given
                if (BasePriceNet <= 0)
                {// Sets BasePriceNet based on the provided Vat and Gross
                    BasePriceNet = CalculatePriceGrossToNet(_basePriceGross, this.Vat);
                    // Returns the value for BasePriceGross
                    return _basePriceGross;
                }
                else // If BasePriceNet is already set, returns BasePriceNet with Vat calculated
                    return CalculatePriceNetToGross(BasePriceNet, this.Vat);
            }
            set => _basePriceGross = value;
        }

        // Proprety for field Additional equipment
        [PositiveNumber]
        public decimal AdditionalEquipmentPriceNet { get; set; }

        private decimal _additionalEquipmentPriceGross;

        [PositiveNumber]
        public decimal AdditionalEquipmentPriceGross
        {
            get
            {// Checks if AdditionalEquipmentPriceNet already set
                if (AdditionalEquipmentPriceNet <= 0)
                {// Sets AdditionalEquipmentPriceNet based on the provided Vat and Gross
                    AdditionalEquipmentPriceNet = CalculatePriceGrossToNet(_additionalEquipmentPriceGross, this.Vat);
                    // Returns the value for AdditionalEquipmentPriceGross 
                    return _additionalEquipmentPriceGross;
                }
                else // If AdditionalEquipmentPriceNet is already set, returns AdditionalEquipmentPriceNet with vat added
                    return CalculatePriceNetToGross(AdditionalEquipmentPriceNet, this.Vat);
            }
            set => _additionalEquipmentPriceGross = value;
        }

        // Proprety for field Total vehicle price
        public decimal TotalPriceNet => AdditionalEquipmentPriceNet + BasePriceNet;

        public decimal TotalPriceGross => AdditionalEquipmentPriceGross + BasePriceGross;

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