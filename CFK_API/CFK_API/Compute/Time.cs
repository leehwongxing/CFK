using System;
using System.IO;

namespace CFK_API.Compute
{
    public class Time
    {
        public static long UnixNow => DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        public static long UnixAt(DateTime t)
            => ((DateTimeOffset)t.ToUniversalTime()).ToUnixTimeSeconds();

        public static DateTime FromUnix(long Tick)
            => new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(Tick);

        public static long Version
            => Convert.ToInt64(File.ReadAllText(".build"));
    }
}
