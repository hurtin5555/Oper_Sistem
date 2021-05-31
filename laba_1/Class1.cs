using System;
using System.IO;

namespace labaratornaya_1_main
{
  class laba_1
  {
    public static void practice_1()
    {
      DriveInfo[] drives = DriveInfo.GetDrives();

      foreach (DriveInfo drive in drives)
      {
        Console.WriteLine($"Название: {drive.Name}");
        Console.WriteLine($"Тип: {drive.DriveType}");
        if (drive.IsReady)
        {
          Console.WriteLine($"Имя файловой системы: {drive.DriveFormat}");
          Console.WriteLine($"Объем диска: {drive.TotalSize}");
          Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
          Console.WriteLine($"Метка: {drive.VolumeLabel}");
        }
        Console.WriteLine();
      }
    }
  }
}
