using System.Collections.Generic;

namespace DCS.FiscalDriverBase
{
    public class Card
    {

        public Card()
        {
            Number = 0;
            DeviceID = "";
        }

        public Card(int number,
                    string deviceID
                   )
        {
            Number = number;
            DeviceID = deviceID;
        }

        public int Number { get; set; } = 0;

        public string DeviceID { get; set; } = "";

        public List<Product> Products { get; set; } = new List<Product>();
        
    }

}
