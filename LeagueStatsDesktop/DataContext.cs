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

        public static Boolean PathExist(string pathToDir, out Boolean x)
        {
            x = Directory.Exists(pathToDir) ? true : false;
            return x;
        }

        public static Boolean FileExist(string dir, string filepath, out Boolean x)
        {
            x = File.Exists($"{dir}/{filepath}") ? true : false;
            return x;
        }

    }
}
