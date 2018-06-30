cls
@ECHO OFF
ECHO. ******************************
ECHO. ** CREATING VIRTUAL MACHINE **
ECHO. ******************************

rem New-VM -Name VM1 -MemoryStartupBytes 256MB -BootDevice VHD -NewVHDPath D:\Parth_Work\VMWare\VM2\VM1.vhdx -Path .\VMData -NewVHDSizeBytes 1GB -Generation 1 -Switch ExternalSwitch
get-vm
rem ipconfig
rem EXIT
pause