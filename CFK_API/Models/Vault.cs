namespace CFK_API.Models
{
    public class Vault
    {
        public string ConnectString { get; set; }

        public string JWT_Secret { get; set; }

        public string Salt { get; set; }

        public Vault()
        {
            ConnectString = "";
            JWT_Secret = "";
            Salt = "";
        }
    }
}
