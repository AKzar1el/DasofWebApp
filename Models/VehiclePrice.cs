namespace DasofWebApp.Models
{
    // Class for calculating vehicle price
    public class VehiclePrice
    {
        // Proprety for field VAT rate
        private decimal _vat;

        public decimal Vat
        {// Returns Vat e.g. 22 % => 0.22
            get { return (_vat / 100); }
            set => _vat = value;
        }

        // Proprety for field Base vehicle price
        public decimal BasePriceNet { get; set; }

        private decimal _basePriceGross;

        public decimal BasePriceGross
        {
            get
            {// Checks if BasePriceNet already set
                if (BasePriceNet <= 0)
                {// Sets BasePriceNet based on the provided Vat and Gross
                    BasePriceNet = _basePriceGross / (1 + this.Vat);
                    // Returns the value
                    return _basePriceGross;
                }
                else // If BasePriceNet is already set, returns BasePriceNet with Vat calculated
                    return (BasePriceNet * this.Vat) + BasePriceNet;
            }
            set => _basePriceGross = value;
        }

        // Proprety for field Additional equipment
        public decimal AdditionalEqPriceNet { get; set; }

        private decimal _additionalEqPriceGross;

        public decimal AdditionalEqPriceGross
        {
            get
            {// Checks if AdditionalEqPriceNet already set
                if (AdditionalEqPriceNet <= 0)
                {// Sets AdditionalEqPriceNet based on the provided Vat and Gross
                    AdditionalEqPriceNet = _additionalEqPriceGross / (1 + this.Vat);
                    // Returns the value
                    return _additionalEqPriceGross;
                }
                else // If AdditionalEqPriceNet is already set, returns AdditionalEqPriceNet with Vat calculated
                    return (AdditionalEqPriceNet * this.Vat) + AdditionalEqPriceNet;
            }
            set => _additionalEqPriceGross = value;
        }

        // Proprety for field Total vehicle price
        public decimal TotalPriceNet
        { get { return AdditionalEqPriceNet + BasePriceNet; } } // Returns the sum of the net fields Base vehicle price and Additional equipment

        public decimal TotalPriceGross
        { get { return AdditionalEqPriceGross + BasePriceGross; } } // Returns the same sum but of the gross fields
    }
}