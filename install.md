---
layout: page
title: "Install"
description: "Sync.Today 2015 installation"
---
{% include JB/setup %}

## Prerequisites
Sync.Today 2015 is a set of .NET libraries and application running on the top of other popular .NET libraries. 
In order to use Sync.Today 2015, you need [.NET Framework 4.5 or higher](http://www.microsoft.com/net) and [Microsoft Orleans](https://github.com/dotnet/orleans).
The easiest way how to install Sync.Today 2015 is using [Chocolatey](https://github.com/chocolatey/choco/wiki/Installation), 
the prerequisites are then installed automatically.

### Chocolatey installation
[Chocolatey install guide](https://github.com/chocolatey/choco/wiki/Installation) is very comprehensive.

## Installation
Sync.Today 2015 is available as a [Chocolatey](https://github.com/chocolatey/choco/wiki/Installation) package. To install it, open elevated command prompt and type
`choco install synctoday -version 15.03.27.2152`.
If you are upgrading from an older release, open elevated command prompt and type
`choco upgrade synctoday -version 15.03.27.2152`.

## Running the local service
