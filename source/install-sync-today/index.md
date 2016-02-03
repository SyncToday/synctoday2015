@{
    Layout = "page";
    Title = "Install Sync.Today";
    Date = "2016-02-03T08:33:14";
    Tags = "";
    Description = "";
}

### Prerequisites
#### SQL Server installation and configuration
Sync.Today 2015 uses Microsoft SQL Server to store its databases. Microsoft SQL Server installation goes beyond the scope of this document. 
Please check [Installation for SQL](https://technet.microsoft.com/library/bb500469.aspx) if needed.
Although we do not recommend it, you can install SQL Server on the same computer as Sync.Today 2015. For better performance, 
install and run SQL Server on a separate dedicated computer. For better performance and improved availability, install and run SQL Server on separate multiple dedicated computers in a clustered configuration.

#### Chocolatey installation
Sync.Today 2015 is installed through Chocolatey. [Chocolatey install guide](https://github.com/chocolatey/choco/wiki/Installation) is very comprehensive and 
you can choose the installation method that would work for you the best. 

### Installing Sync.Today 2015
Sync.Today 2015 is available as a Chocolatey package. To install it, open the elevated command prompt and type `choco install synctoday -source http://sync-today-nuget.azurewebsites.net/nuget`.
Chocolatey packages are installed to `%ProgramData%\chocolatey\lib` by default. 
If the installation was successful, you will find `%ProgramData%\chocolatey\lib\synctoday` subfolder and shim `sync.today.temp.workflowapp.exe` will be created in `%ProgramData%\chocolatey\bin`.

### Upgrading Sync.Today 2015
If you are upgrading from an older release, open the elevated command prompt and type `cup synctoday -source https://sync-today-nuget.azurewebsites.net/nuget`.

### Post-installation configuration
#### Sync.Today database

Sync.Today 2015 uses Microsoft SQL Server database to store the configuration, information about the users, service accounts or synchronized entities.
After a fresh Sync.Today installation the new database needs to be created. To create Sync.Today 2015 database use supplied 
`sync.today.createdb.exe` console application that will create both the database and the database structure. 
Please note if the database is about to be created, default SQL Server folder will be used to store the database (MDF and LDF) files.
The syntax is 
`sync.today.createdb <<connection string>>` e.g. `sync.today.createdb "Server=(localdb)\MSSQLLocalDB; Database=SyncToday2015; Trusted_Connection=True;"`
To help you construct the connection string check [SqlClient Connection Strings](https://msdn.microsoft.com/en-us/library/ms254500%28v=vs.110%29.aspx) or 
[SQL Server 2012 Connection Strings](https://www.connectionstrings.com/sql-server-2012/).

#### Master.config XML Configuration file
Although the Sync.Today 2015 configuration is stored in the database, there is a XML configuration file `master.config` too to navigate the Sync.Today 2015 
applications to the database and also to configure assembly redirects and logging.
When an Sync.Today 2015 application is started it first copies the `master.config` to its directory and uses it as the application configuration file.

##### Master.config location
The default `master.config` location is in the `sync.today` folder under `%ProgramFiles%`.
If for some reasons `%ProgramFiles%` is not usable, you can specify the location of folder **parent** to the `sync.today` folder  in `ConfigDir` registry string value under `HKCU\Software\Sync.Today` key.
So if you have `C:\` in `HKCU\Software\Sync.Today\ConfigDir`, the final path to `master.config` will be `C:\sync.today\master.config`.

##### Master.config content
`Master.config` is an [application configuration file](https://msdn.microsoft.com/en-us/library/1xtk877y%28v=vs.110%29.aspx). 
See [an example of Master.config](https://gist.github.com/davidpodhola/ec0f4bad1ddde25dac06).

###### Database connection string
Sync.Today 2015 uses the database connection string named `sync-today-mssql` from `connectionStrings` section. You can use the same you used to run `sync.today.createdb` or 
you can modify the security settings (user name and password) if needed.

###### Logging
[Log4net](https://logging.apache.org/log4net/) is the logging framework Sync.Today 2015 is using. Several named loggers are used so specific logs are created for administrators, 
developers or to document the synchronization process:

* `root` logger - events related to the synchronization process e.g. connecting to the database, connecting to different services, data download-transformation-upload
* `DevLog` logger - more specific developer related log information
* `IgnoreLog` logger - when entity changes are ignored the information goes here
* `WinnerLog` logger - how the synchronization winner entity looks like
* `_data_before` and `_data_after` loggers - to store the content of adapter-specific data tables before and after the synchronization

When Sync.Today is installed go on with the [Configuration](/configure-sync-today/index.html).
