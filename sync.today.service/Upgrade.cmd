NET STOP "Sync.Today Main Service"

cup synctoday -source http://sync-today-nuget.azurewebsites.net/nuget

sync.today.service install

NET START "Sync.Today Main Service"
