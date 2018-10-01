using System;

namespace CFK_API.Compute
{
    public class Time
    {
        public static long UnixNow => DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        public static long UnixAt(DateTime t) => ((DateTimeOffset)t.ToUniversalTime()).ToUnixTimeSeconds();
    }
}
