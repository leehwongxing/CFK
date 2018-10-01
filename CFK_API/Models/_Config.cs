namespace CFK_API.Models
{
    public class _Config
    {
        public string ConnectString { get; set; }

        public string JWT_Secret { get; set; }

        public string Salt { get; set; }

        public _Config()
        {
            ConnectString = "";
            JWT_Secret = "";
            Salt = "";
        }
    }
}