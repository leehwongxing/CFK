using Jil;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace CFK_API.Compute
{
    public interface ISample
    {
        string Type { get; }

        bool LoadSample();

        bool SaveSample();
    }

    public class Sample<T> : ISample, IDisposable
    {
        public string Type => typeof(T).FullName;

        private static readonly string Location = ".Data";

        public IQueryable<T> DataSource { get; set; }

        public Sample()
        {
            LoadSample();
        }

        public bool LoadSample()
        {
            try
            {
                var DataFile = Path.Combine(Location, Type);

                if (!File.Exists(DataFile))
                    File.Create(DataFile);

                DataSource = JSON
                    .Deserialize<IQueryable<T>>(File
                    .ReadAllText(DataFile));
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                DataSource = null;
                return false;
            }
        }

        public bool SaveSample()
        {
            try
            {
                var DataFile = Path.Combine(Location, Type);

                using (var Stream = File.Open(
                    DataFile,
                    FileMode.Create,
                    FileAccess.Write,
                    FileShare.None))
                using (var Writer = new StreamWriter(
                    Stream,
                    Encoding.UTF8,
                    10240))
                {
                    Writer.Write(JSON.Serialize(DataSource));
                    Writer.Flush();
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public void Dispose()
        {
            SaveSample();
        }
    }
}
