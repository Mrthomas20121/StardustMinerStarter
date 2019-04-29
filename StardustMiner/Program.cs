using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StardustMiner
{
    class Program
    {
        static void Main(string[] args)
        {
            Process java = new Process();
            java.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + "jre/bin/java.exe";
            java.StartInfo.Arguments = "-jar ./bin/stardust.jar";
            java.Start();
        }
    }
}
