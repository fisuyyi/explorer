using System.Numerics;
using System.Reflection.Metadata;

namespace fileexplorer
{
    internal class Program
    {
        static void Main()
        {
            do
            {
                explorer.Final();
            }while(true);
            
        }

        /*static void Info()
        {
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("Этот компьютер");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            Console.SetCursorPosition(0, 3);
            foreach (DriveInfo d in allDrives)
            {
                BigInteger a = d.TotalFreeSpace;
                a /= 1073741824;
                BigInteger b = d.TotalSize;
                b /= 1073741824;
                
                Console.WriteLine($"  {d.Name} {a} ГБ свободно из {b}");
            }
        }*/

    }
}