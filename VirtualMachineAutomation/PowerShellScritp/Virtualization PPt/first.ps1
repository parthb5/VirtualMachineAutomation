# Get the ID and security principal of the current user account

$myWindowsID=[System.Security.Principal.WindowsIdentity]::GetCurrent()

$myWindowsPrincipal=new-object System.Security.Principal.WindowsPrincipal($myWindowsID)

 

# Get the security principal for the Administrator role

$adminRole=[System.Security.Principal.WindowsBuiltInRole]::Administrator

 

# Check to see if we are currently running "as Administrator"

if ($myWindowsPrincipal.IsInRole($adminRole))

   {
   Write-Host -NoNewLine "Administrator..."
   $null = $Host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")

   # We are running "as Administrator" - so change the title and background color to indicate this

   #$Host.UI.RawUI.WindowTitle = $myInvocation.MyCommand.Definition + "(Elevated)"

   #$Host.UI.RawUI.BackgroundColor = "Red"

   clear-host

   }

else

   {
   Write-Host -NoNewLine "User..."
   $null = $Host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")
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

 

# Run your code that needs to be elevated here
New-VM -Name VM1 -MemoryStartupBytes 256MB -BootDevice VHD -NewVHDPath D:\Parth_Work\VMWare\VM1\VM1.vhdx -Path .\VMData -NewVHDSizeBytes 1GB -Generation 1 -Switch ExternalSwitch
Write-Host -NoNewLine "Press any key to continue..."

$null = $Host.UI.RawUI.ReadKey("NoEcho,IncludeKeyDown")