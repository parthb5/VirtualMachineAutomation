using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMachineAutomation
{
    class CallPowerShell
    {
        public static void CallScript(string FileName)
        {
            try
            {
                string strCmdText = Path.Combine(Directory.GetCurrentDirectory(), FileName);
                //C:\Users\parth\Desktop
                var process = new Process();
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.Verb = "runas";
                process.StartInfo.FileName = @"C:\windows\system32\windowspowershell\v1.0\powershell.exe";
                process.StartInfo.Arguments = strCmdText;

                process.Start();
                string s = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                using (StreamWriter outfile = new StreamWriter("D:\\StandardOutput.txt", true))
                {
                    outfile.Write(s);
                }
            }
            catch (Exception ex)
            {
                throw ex.GetBaseException();
            }            
        }
    }
}
