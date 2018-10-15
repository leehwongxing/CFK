using System;
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

        public static void Clear(string directory = "")
        {
            if (directory == "") directory = FileStore;

            File.SetAttributes(directory, FileAttributes.Normal);

            string[] files = Directory.GetFiles(directory);
            string[] dirs = Directory.GetDirectories(directory);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                Clear(dir);
            }

            Directory.Delete(directory, false);
        }
    }
}
