---
layout: page
title: "Install"
description: "Sync.Today 2015 installation"
---
{% include JB/setup %}

## Prerequisites
Sync.Today 2015 is a set of .NET libraries and application running on the top of other popular .NET libraries. 
In order to use Sync.Today 2015, you need [.NET Framework 4.5 or higher](http://www.microsoft.com/net) and [Microsoft Orleans](https://github.com/dotnet/orleans).
The easiest way how to install Sync.Today 2015 is using [Chocolatey](https://github.com/chocolatey/choco/wiki/Installation)<strike>, 
the prerequisites are then installed automatically</strike>.

### Chocolatey installation
[Chocolatey install guide](https://github.com/chocolatey/choco/wiki/Installation) is very comprehensive 
and you can choose the installation method that would work for you the best.
If you can run the elevated command prompt, 

![How to run elevated command prompt](/images/1run_cmd_as_admin.png)

probably the easiest way to install is to run 

`@powershell -NoProfile -ExecutionPolicy unrestricted -Command`
`"(iex ((new-object net.webclient).DownloadString('https://chocolatey.org/install.ps1')))`
`>$null 2>&1" && SET PATH=%PATH%;%ALLUSERSPROFILE%\chocolatey\bin`

![Chocolatey successfully installed](/images/2choco_installed.png)

Later on you can upgrade to the latest version running `choco upgrade chocolatey` from the elevated command prompt (`chocolatey update` if running older version than 0.9.9).
Note versions from 0.9.9 and later would require you to confirm the upgrade.

![Confirm Chocolatey upgrade](/images/2achoco_upgrade.png)

Anytime you can check the version you have installed by running simply `choco` from the elevated command prompt.

### Microsoft Orleans installation
[Microsoft Orleans documentation web](http://dotnet.github.io/orleans/) does not include at the present time any installation guide besides the [SDK installation](http://dotnet.github.io/orleans/Installation).
The easy way to install Microsoft Orleans might be again running Chocolatey install from the elevated command prompt: <strike>choco install orleans</strike> `choco install orleans -source https://sync-today-nuget.azurewebsites.net/nuget`

![Orleans installed](/images/4orleans_installed.png)

## Installation
Sync.Today 2015 is available as a [Chocolatey](https://github.com/chocolatey/choco/wiki/Installation) package. To install it, open the elevated command prompt and type <strike>choco install synctoday -version 15.03.27.2152</strike> `choco install synctoday -source http://sync-today-nuget.azurewebsites.net/nuget --sidebyside`.

![Sync.Today installed](/images/3synctoday_installed.png)

If you are upgrading from an older release, open the elevated command prompt and type <strike>choco upgrade synctoday -version 15.03.27.2152</strike> `cup synctoday -source https://sync-today-nuget.azurewebsites.net/nuget --sidebyside`.

