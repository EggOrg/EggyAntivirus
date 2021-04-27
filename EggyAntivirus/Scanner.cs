﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static EggyAntivirus.Util;
using static EggyAntivirus.StoreInfo;
using System.Net;

namespace EggyAntivirus
{
    class Scanner
    {
        public static List<string> unsafefiles = new List<string>();
        public static List<string> unknownfiles = new List<string>();
        public static int unsafeproc = 0;
        public static int unknownproc = 0;
        public static int safeproc = 0;
        private static string[] hostcntn = (new WebClient().DownloadString(host)).Split(' ');
        public static void ScanFile(string path)
        {
            try
            {
                int unsc = 0;
                string thishash = GetMD5(path);
                foreach (string dethash in hostcntn)
                {
                    Console.Title = $"{name} - testing {path} against {dethash}";
                    if (dethash == thishash)
                    {
                        unsc++;
                    }
                }

                if (unsc > 0)
                {
                    unsafefiles.Add(path);
                    unsafeproc++;
                }
                else
                {
                    safeproc++;
                    unknownfiles.Add(path);
                }
            }
            catch
            {
                unknownproc++;
            }
        }
    }
    class GetFiles
    {
        public static int unscanned = 0;
        public static List<string> allfiles = new List<string>();

        public static void ApplyAllFiles(string folder, Action<string> fileAction)
        {
            foreach (string file in Directory.GetFiles(folder))
            {
                fileAction(file);
            }
            foreach (string subDir in Directory.GetDirectories(folder))
            {
                try
                {
                    ApplyAllFiles(subDir, fileAction);
                }
                catch
                {
                    unscanned++;
                }
            }
        }
    }
}