cls
@ECHO OFF
ECHO. ******************************
ECHO. ** CREATING VIRTUAL MACHINE **
ECHO. ******************************

accesses syswow64
accesses System32
New-VM -Name VM1 -MemoryStartupBytes 256MB -BootDevice VHD -NewVHDPath D:\Parth_Work\VMWare\VM2\VM1.vhdx -Path .\VMData -NewVHDSizeBytes 1GB -Generation 1 -Switch ExternalSwitch
rem vm
rem ipconfig
EXIT