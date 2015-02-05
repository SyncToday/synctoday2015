@echo off
rem installutil="C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\installutil.exe"
set installutil="C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\installutil.exe"

rem Start the service
NET STOP  sync.today.service.Main

rem Uninstall the service
%installutil% /u ".\sync.today.service.exe"

pause
