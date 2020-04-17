namespace DCS.FiscalDriverBase
{
    public class CurrencyType
    {

        public CurrencyType(int id = 0,
                              int typeID = 0,
                              string description = "",
                              decimal exchangeRatio = 0,
                              bool needsPIN = false
                             )
        {
            ID = id;
            TypeID = typeID;
            Description = description;
            ExchangeRatio = exchangeRatio;
            NeedsPIN = needsPIN;
        }

        public int ID { get; set; } = 0;

        public int TypeID { get; set; } = 0;

        public string Description { get; set; } = "";

        public decimal ExchangeRatio { get; set; } = 1;

        public bool NeedsPIN { get; set; } = false;
        
    }
}