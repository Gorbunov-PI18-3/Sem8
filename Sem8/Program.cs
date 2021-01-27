using System;
using System.IO;


namespace Sem8
{
    class Program
    {
        public static void Main()
        {
            DirectoryInfo dirInfo = new DirectoryInfo("с:\\папка\\");
            
            foreach (FileInfo file in dirInfo.GetFiles())
            {
            // TimeSpan t = TimeSpan.FromMinutes(30);
                file.Delete();
            }

        }
    }
}
