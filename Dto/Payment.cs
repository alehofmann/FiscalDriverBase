namespace DCS.FiscalDriverBase
{
    public class Payment
    {

        public Payment()
        {
            Paid = 0;
            Tendered = 0;
            Currency = new CurrencyType();
            AuthorizationCode = "";
        }

        public Payment(decimal paid,
                       decimal tendered
                      )
        {
            Paid = paid;
            Tendered = tendered;
            Currency = new CurrencyType();
            AuthorizationCode = "";
        }

        public Payment(decimal paid,
                       decimal tendered,
                       CurrencyType currency
                      )
        {
            Paid = paid;
            Tendered = tendered;
            Currency = currency;
            AuthorizationCode = "";
        }

        public Payment(decimal paid,
                       decimal tendered,
                       CurrencyType currency,
                       string authCode
                      )
        {
            Paid = paid;
            Tendered = tendered;
            Currency = currency;
            AuthorizationCode = authCode;
        }

        public decimal Paid { get; set; } = 0;

        public decimal Tendered { get; set; } = 0;

        public decimal Change
        {
            get
            {
                return (Tendered - Paid);
            }
        }

        public CurrencyType Currency { get; set; } = new CurrencyType();

        public string AuthorizationCode { get; set; } = "";

    }
}