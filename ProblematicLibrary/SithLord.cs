using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblematicLibrary
{
    public class SithLord
    {
        public static void ExecuteOrder66()
        {
            Process.Start("explorer.exe", $@"{Directory.GetCurrentDirectory()}\OldManCanoli.jpg");
        }
    }
}
