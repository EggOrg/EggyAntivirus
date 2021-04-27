using System;
using System.IO;
using static EggyAntivirus.Printer;
using static EggyAntivirus.Scanner;
using static EggyAntivirus.GetFiles;
using static EggyAntivirus.Util;
using static EggyAntivirus.Methods;
using static EggyAntivirus.StoreInfo;

namespace EggyAntivirus
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MakeDivider(name);
            if (args.Length < 2)
            {
                PrintError("Please give a command.");
            }
            else
            {
                if (args[0].Equals("scandir"))
                {
                    if (!(Directory.Exists(args[1])))
                    {
                        PrintError("Directory nonexistent.");
                    }
                    else
                    {
                        ApplyAllFiles(args[1], Process);
                        PrintSafe(safeproc);
                        PrintUnknown(unknownproc);
                        PrintUnsafe(unsafeproc);
                        ListUnsafeFiles(unsafefiles);
                    }
                }
                else if (args[0].Equals("scanfile"))
                {
                    if (!(File.Exists(args[1])))
                    {
                        PrintError("File nonexistent.");
                    }
                    else
                    {
                        ScanFile(args[1]);
                        PrintSafe(safeproc);
                        PrintUnknown(unknownproc);
                        PrintUnsafe(unsafeproc);
                        ListUnsafeFiles(unsafefiles);
                    }
                }
                else if (args[0].Equals("listdir"))
                {
                    if (!(Directory.Exists(args[1])))
                    {
                        PrintError("Directory nonexistant.");
                    }
                    else
                    {
                        ApplyAllFiles(args[1], CountFile);
                        PrintInfo($"File count: {count}");
                        ApplyAllFiles(args[1], ListFile);
                    }
                }
                else if (args[0].Equals("getmd5"))
                {
                    if (!(File.Exists(args[1])))
                    {
                        PrintError("File nonexistant");
                    }
                    else
                    {
                        Console.WriteLine(GetMD5(args[1]));
                    }
                }
                else
                {
                    PrintError("Unknown command.");
                }
            }
        }
    }
}
