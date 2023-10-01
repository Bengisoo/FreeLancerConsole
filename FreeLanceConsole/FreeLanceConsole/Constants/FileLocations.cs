using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeLanceConsole.Constants
{
    internal class FileLocations
    {
        public static string ProjectFolder=> 
            Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        //C:\Users\zehra\source\repos\FreeLanceConsole\FreeLanceConsole\Constants\FileLocations.cs
    }
}
