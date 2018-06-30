
$parsed =  Get-Content -Raw -Path C:\Users\parth\Desktop\PowerShellScritp\UpdateRAM.json | ConvertFrom-Json
$VMName = $parsed.VMName
$RAM = $parsed.RAM
#Write-Host $VMName
#Write-Host $RAM
if (!([Security.Principal.WindowsPrincipal] [Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole] "Administrator"))
   {
   # We are not running "as Administrator" - so relaunch as administrator   
   # Create a new process object that starts PowerShell
   $newProcess = new-object System.Diagnostics.ProcessStartInfo "PowerShell";
   
   # Specify the current script path and name as a parameter
   $newProcess.Arguments = $myInvocation.MyCommand.Definition;
   
   # Indicate that the process should be elevated
   $newProcess.Verb = "runas";
   
   # Start the new process
   [System.Diagnostics.Process]::Start($newProcess);
   
   # Exit from the current, unelevated, process
   exit
   }
Stop-VM $VMName
Set-VM -StaticMemory -Name $VMName -MemoryStartupBytes $RAM
Start-VM $VMName

