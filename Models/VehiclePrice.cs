namespace DasofWebApp.Models
{
    // Class for calculating vehicle price
    public class VehiclePrice
    {
        // Proprety for field VAT rate
        public decimal Vat { get; set; }

        // Proprety for field Base vehicle price
        public decimal BasePriceNet { get; set; }
        public decimal BasePriceGross { get; set; }

        // Proprety for field Additional equipment
        public decimal AdditionalEqPriceNet { get; set; }
        public decimal AdditionalEqPriceGross { get; set; }

        // Proprety for field Total vehicle price
        public decimal TotalPriceNet
        { get { return AdditionalEqPriceNet + BasePriceNet; } }
        public decimal TotalPriceGross
        { get { return AdditionalEqPriceGross + BasePriceGross; } }
    }
}