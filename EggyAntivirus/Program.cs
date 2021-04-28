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
            Console.Title = $"{name} - {commandprefix}";
            if (args.Length < 1)
            {
                PrintError("Please give a command.");
            }
            else
            {
                if (args[0].Equals("scandir"))
                {
                    if (args.Length < 2)
                    {
                        PrintError("Not enough args.");
                    }
                    else
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
                }
                else if (args[0].Equals("scanfile"))
                {
                    if (args.Length < 2)
                    {
                        PrintError("Not enough args.");
                    }
                    else
                    {
                        if (!(File.Exists(args[1])))
                        {
                            PrintError("File nonexistent.");
                        }
                        else
                        {
                            ScanFile(args[1]);
                            if (ishostcntnlong)
                            {
                                PrintInfo("The definition values are long. This could impact the time taken to scan files.");
                            }
                            PrintSafe(safeproc);
                            PrintUnknown(unknownproc);
                            PrintUnsafe(unsafeproc);
                            ListUnsafeFiles(unsafefiles);
                        }
                    }
                }
                else if (args[0].Equals("listdir"))
                {
                    if (args.Length < 2)
                    {
                        PrintError("Not enough args.");
                    }
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
                    if (args.Length < 2)
                    {
                        PrintError("Not enough args.");
                    }
                    else
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
                }
                else if (args[0].Equals("help"))
                {
                    Console.WriteLine($@"scandir - Scans a directory of files. - {commandprefix} scandir (Directory)");
                    Console.WriteLine($@"scanfile - Scans a file. - {commandprefix} scanfile (File)");
                    Console.WriteLine($@"listdir - Lists a directory of files. - {commandprefix} listdir (Directory)");
                    Console.WriteLine($@"getmd5 - Gets the MD5 hash of a file. - {commandprefix} getmd5 (File)");
                    Console.WriteLine($@"help - Lists this help menu. - {commandprefix} help");
                }
                else
                {
                    PrintError("Unknown command.");
                }
            }
        }
    }
}
