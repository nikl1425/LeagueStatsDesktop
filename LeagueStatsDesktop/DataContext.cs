using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LeagueStatsDesktop
{
    static class DataContext
    {
        private static readonly string _filesPath = "Files";
        
        public static string FilesPath { get { return _filesPath; } }

        public static bool PathExist(string pathToDir, out bool x)
        {
            x = Directory.Exists(pathToDir) ? true : false;
            return x;
        }

        public static string GetProjPath(bool? withFilesMapping)
        {
            if (withFilesMapping == null || false)
            {
                return Path.GetFullPath(@"..\..\..\");
            }
            return Path.GetFullPath(@"..\..\..\Files\");
        }

        public static bool FileExist(string dir, string filepath, out Boolean x)
        {
            string startUpPath = Path.GetFullPath(@"..\..\..\");
            string pathToFile = $"{startUpPath}{dir}\\{filepath}";
            x = File.Exists(pathToFile);
            return x;
        }
    }
}
