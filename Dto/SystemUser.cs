namespace DCS.FiscalDriverBase
{
    public class SystemUser
    {

        public SystemUser
            (int id = 0,
             string firstName = "",
             string lastName = "",
             string nick = "",
             int cardNumber = 0
            )
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Nick = nick;
            Card = cardNumber;
        }

        public int ID { get; set; } = 0;

        public string FirstName { get; set; } = "";

        public string LastName { get; set; } = "";

        public string Nick { get; set; } = "";

        public int Card { get; set; } = 0;

    }
}