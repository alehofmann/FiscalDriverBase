using System.Collections.Generic;

namespace DCS.FiscalDriverBase
{
    public class Product
    {

        public Product()
        {
            ID = 0;
            Description = "";
            UnitPrice = 0;
            Quantity = 0;
            Taxes = new List<Tax>();
            Modifiers = new List<Modifier>();
            SpecialRequest = "";
        }

        public Product(int id = 0,
                       string description = "",
                       decimal unitPrice = 0,
                       decimal quantity = 0,
                       string specialRequest = ""
                      )
        {
            ID = id;
            Description = description;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Taxes = new List<Tax>();
            Modifiers = new List<Modifier>();
            SpecialRequest = specialRequest;
        }

        public int ID { get; set; } = 0;

        public string Description { get; set; } = "";

        public decimal UnitPrice { get; set; } = 0;

        public decimal Quantity { get; set; } = 0;

        public List<Tax> Taxes { get; set; } = new List<Tax>();

        public List<Modifier> Modifiers { get; set; } = new List<Modifier>();

        public string SpecialRequest { get; set; } = "";

    }
}
