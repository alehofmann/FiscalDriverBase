namespace DCS.FiscalDriverBase
{
    public class Tax
    {

        public enum TaxType
        {
            Undefined = 0,
            SalesTax = 1,
            VATType = 2
        }

        public Tax(int id = 0,
                   TaxType type = TaxType.Undefined,
                   decimal rate = 0,
                   string description = "",
                   decimal taxableBase = 0,
                   decimal amount = 0
                  )
        {
            ID = id;
            Type = type;
            Rate = rate;
            Description = description;
            TaxableBase = taxableBase;
            Amount = amount;
        }

        public int ID { get; set; } = 0;

        public TaxType Type { get; set; } = TaxType.Undefined;

        public decimal Rate { get; set; } = 0;

        public string Description { get; set; } = "";

        public decimal TaxableBase { get; set; } = 0;

        public decimal Amount { get; } = 0;
        
    }
}