@echo off
rem installutil="C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\installutil.exe"
set installutil="C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\installutil.exe"

rem Install the new service
%installutil% ".\sync.today.service.exe"

rem Start the service
NET START sync.today.service.Main
pause
