using System;
using System.IO;

namespace SysteemInformatie
{
    class Program
    {
        static void Main(string[] args)
        {
            double geheugen = Environment.WorkingSet;
            Console.WriteLine($"storrage: {geheugen / 1024} KB");
            Console.WriteLine($"storrage: {geheugen / 1048576} MB");

            Console.WriteLine("van welke hardeschijf wil je informatie?");
            int invoer = Convert.ToInt32(Console.ReadLine()) - 1;

            long driverFreeSpace = DriveInfo.GetDrives()[invoer].AvailableFreeSpace;
            long totalsize = DriveInfo.GetDrives()[invoer].TotalSize;
            Console.WriteLine($"vrij geheugen: {driverFreeSpace / 1073741824} GB");
            Console.WriteLine($"totaal geheugen: {totalsize / 1073741824} GB");
        }
    }
}
