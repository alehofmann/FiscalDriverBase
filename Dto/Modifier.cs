namespace DCS.FiscalDriverBase
{
    public class Modifier
    {

        public Modifier(int id = 0,
                          string description = "",
                          decimal unitPrice = 0
                         )
        {
            ID = id;
            Description = description;
            UnitPrice = unitPrice;
        }

        public int ID { get; set; } = 0;

        public string Description { get; set; } = "";

        public decimal UnitPrice { get; set; } = 0;

    }
}