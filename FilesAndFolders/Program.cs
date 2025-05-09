using System.Text;

namespace FilesAndFolders;

class Program
{
    static void Main(string[] args)
    {
      
       // FileWorks();
       PathWorks();
    }

    public static void PathWorks()
    {
        string path = Directory.GetCurrentDirectory();
        string [] parts = path.Split(Path.DirectorySeparatorChar);
        foreach (var part in parts)
        {
            Console.WriteLine(part);
        }
        
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i < parts.Length; i++)
        {
            sb.Append(Path.DirectorySeparatorChar)
            .Append(parts[i]);
        }

        Console.WriteLine(sb.ToString());
    }

    public static void FileWorks()
    {
        FileInfo fi = new FileInfo("test.txt");
        if (!fi.Exists)
        {
            using (StreamWriter sw = fi.CreateText())
            {
                sw.WriteLine("Ein wenig text...");
            }
            
            Console.WriteLine(fi.FullName);
            Console.ReadKey();
            
            fi.MoveTo(@"C:\Temp\Do7_test.txt");
            Console.WriteLine(fi.FullName);
            Console.ReadKey();
            
            fi.CopyTo(@".\Do7_test2.txt");
            Console.WriteLine(fi.FullName);
            Console.ReadKey();
            
            fi.Delete();
        }
    }

    public static void DirectoryWorks(string path)
    {
        DirectoryInfo di = new DirectoryInfo(path);
        if (!di.Exists)
        {
            di.Create();
            di.CreateSubdirectory("test");
            
            FileSystemInfo[] infos = di.GetFileSystemInfos();
            
            foreach (var fsi in infos)
            {
                Console.WriteLine(fsi.Name);
            }

            Console.ReadKey();
            di.Delete(true);
        }
        else
        {
            Console.WriteLine("Verzeichnis existiert bereits");
        }
    }

    static void PrintDriveInfo()
    {
        DriveInfo.GetDrives();
        var drives = DriveInfo.GetDrives();
        foreach (var drive in drives)
        {
            Console.WriteLine($"Drive: {drive.Name}");
            Console.WriteLine($"Type.: {drive.DriveType}");
            if (drive.IsReady)
            {
                Console.WriteLine($"Lable: {drive.VolumeLabel}");
                Console.WriteLine($"System: {drive.DriveFormat}");
                Console.WriteLine($"Size: {drive.TotalSize}");
                Console.WriteLine($"Free: {drive.TotalFreeSpace}");
            }
        }
        
    }
}