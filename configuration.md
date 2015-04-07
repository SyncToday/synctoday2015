---
layout: page
title: "Configuration"
description: "The Sync.Today 2015 Configuration Files"
---
{% include JB/setup %}

All the Sync.Today 2015 main configuration is done in `C:\Program Files (x86)\Sync.Today\master.config`. 
Orleans client is configured in `C:\Program Files (x86)\Sync.Today\ClientConfiguration.xml`.

###  master.config
A working example of Sync.Today Master.config can be found in [build artifacts](https://ci.appveyor.com/project/davidpodhola/synctoday2015/build/artifacts) e.g. sync.today.dll.config (also found in [the GitHub source as Web.config](https://github.com/SyncToday/synctoday2015/blob/master/sync.today/Web.config)).

#### log4net
For general logging we use [log4net](https://logging.apache.org/log4net/). `<configuration>` section thus should start with
`<configSections>`
	`<section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net" />`
`</configSections>`

Later in the config file, the logging is set.
