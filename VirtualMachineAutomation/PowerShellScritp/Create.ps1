﻿cls
$parsed =  Get-Content -Raw -Path C:\Users\parth\Desktop\PowerShellScritp\Create.json | ConvertFrom-Json
$VMName = $parsed.vm_name
$RAM = $parsed.vm_ram
$Storage = $parsed.vm_vhd
$Path = "D:\Parth_Work\VMWare\$VMName"
$SwitchName = $parsed.vm_nic

$VM = @{
  Name = $VMName 
  MemoryStartupBytes = $RAM
  Generation = 1
  NewVHDPath = "$path\$VMName.vhdx"
  NewVHDSizeBytes = $Storage
  BootDevice = "VHD"
  Path = "$Path"
  SwitchName = $SwitchName
  }

#New-VM @VM | Out-File 'D:\StandardOutput.txt' -Append

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
New-VM @VM