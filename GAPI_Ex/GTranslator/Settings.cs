using System;
using System.Diagnostics;
using System.IO;

namespace GTranslator
{
    public static class Settings
    {
        public static string FileStore { get; private set; }

        public static string AppName { get; private set; }

        static Settings()
        {
            AppName = "GTranslator";

            FileStore = Path.Combine(Environment.CurrentDirectory, ".users");
        }

        public static void ResetCredential()
        {
            File.Delete(Settings.FileStore);
        }
    }
}
