using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject.models
{
    internal static class Logger
    {
        private static string LogPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DatabaseProject");
        private static string LogFilePath = Path.Combine(LogPath, "log.txt");
        public static void LogException(string ex)
        {
            if (ex != null) 
            { 
                File.AppendAllText(LogFilePath, DateTime.Now + "\t" + ex + Environment.NewLine);
            }
        }
        public static void Initialize()
        {
            if (!Directory.Exists(LogPath))
            {
                Directory.CreateDirectory(LogPath);
                using (FileStream fs = File.Create(LogFilePath))
                {

                }
            }
        }
    }
}
