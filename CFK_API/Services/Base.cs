using CFK_API.Models;
using Jil;
using System;
using System.Data.SqlClient;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace CFK_API.Services
{
    public interface IDbContainer
    {
        SqlConnection Connect();

        Models._Config Config { get; }
    }

    public class Base : IDbContainer
    {
        private static readonly Lazy<Base> LazyBase = new Lazy<Base>(() => new Base());

        public static Base Container { get { return LazyBase.Value; } }

        public _Config Config => _config;

        private readonly string PlainFile = ".poco";

        private readonly string CompressedFile = ".sys";

        private _Config _config { get; set; }

        private SqlConnection _conn { get; set; }

        private Base()
        {
            _config = new _Config();

            if (!File.Exists(CompressedFile))
            {
                CompressData();
            }
            else
            {
                DecompressData();
            }
        }

        private void CompressData()
        {
            try
            {
                var PlainConfig = File.ReadAllBytes(PlainFile);

                _config = JSON.Deserialize<_Config>(Encoding.UTF8.GetString(PlainConfig));

                using (var FS = new FileStream(CompressedFile, FileMode.CreateNew))
                using (var DF = new DeflateStream(FS, CompressionMode.Compress))
                {
                    DF.Write(PlainConfig, 0, PlainConfig.Length);
                    DF.Flush();
                }

                File.Delete(PlainFile);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void DecompressData()
        {
            if (!File.Exists(CompressedFile))
            {
                return;
            }

            try
            {
                var MS = new MemoryStream();

                using (var FS = File.OpenRead(CompressedFile))
                using (var DF = new DeflateStream(FS, CompressionMode.Decompress))
                {
                    DF.CopyTo(MS);
                }

                _config = JSON.Deserialize<Models._Config>(Encoding.UTF8.GetString(MS.ToArray()));
                MS.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public SqlConnection Connect()
        {
            try
            {
                if (_conn == null)
                {
                    _conn = new SqlConnection(Config.ConnectString);
                    _conn.Open();
                }

                return _conn;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
