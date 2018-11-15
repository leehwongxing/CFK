namespace CFK_API.Compute
{
    public class Etc
    {
        public static string IDed(string Input = "")
            => Input.Trim().Replace("  ", " ").Replace(" ", "_").ToUpperInvariant();
    }
}
