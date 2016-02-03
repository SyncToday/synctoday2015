@{
    Layout = "page";
    Title = "Configure Sync.Today";
    Date = "2016-02-03T08:35:31";
    Tags = "";
    Description = "";
}
Sync.Today configuration consists of

* Synchronization data configuration - The data to be synchronized are configured in several database tables
* Synchronization algorithm - the synchronization algorithm itself is [WCF Workflow](https://msdn.microsoft.com/en-us/library/dd456788%28v=vs.110%29.aspx) configured in several XAML files; 
to modify Synchronization algorithm please refer to [Customizations](/customize-sync-today/index.html)
* Switches, default values etc. - adapter-specific configuration properties are stored in `master.config`; please see adapter specific parts of this page to find out those values

### Database
The tables are listed in the order the data should be `INSERT`ed in them.

#### Services
`Services` table contains the list of the services Sync.Today is about to synchronize. 
The `Key` column is later used by `EnsureService` activity in the synchronization workflow. 
The `Id` column is referenced by other tables e.g. `ServiceAccounts`.
#### Adapters
`Adapters` table contains the list of the adapters Sync.Today is about to use to connect to services. 
The `Key` column is later used by `EnsureAdapter` activity in the synchronization workflow. The `Id` column is referenced by other tables e.g. `ConsumerAdapters`.

**NOTE** There is no database relation between `Services` and `Adapters` tables as this is adapter-specific.
#### Consumers
`Consumers` table contains the list of the synchronized consumers. The `Id` column is referenced by other tables e.g. `ConsumerAdapters`.
#### ConsumerAdapters
`ConsumerAdapters` table is the M:N relation table between `Adapters` and `Consumers`. Lists the real entity containers so a row in `ConsumerAdapters` table might represent Joe's Exchange calendar or Mike's task list in Google.
The `DateJSON` column contains the adapter-specific user identification in the service.

**IMPORTANT** The `DateJSON` column is not checked at the database layer at all. It is the only single mapping used to distinguish among users if bulk or technical users are used.
**Double check** as incorrect configuration here will lead to **serious data mismatch** that are almost impossible to fix later.

**NOTE** When it seems user's data are not synchronized check `ConsumerAdapters` table first.

The `Id` column is referenced by other tables.
#### Accounts
`Accounts` table contains the list of the service's accounts either real users (consumers) or technical accounts. The `Id` column is referenced by other tables e.g. `ServiceAccounts`.

**IMPORTANT** If an account is also a consumer (for non-bulk non-technical user adapters), fill the `ConsumerId` column to the corresponding row from `ConsumerAdapters` table.

#### ServiceAccounts
`ServiceAccounts` table contains the list of the service's accounts with their connection details e.g. user name and encrypted password. The `Id` column is referenced by other tables e.g. `ExchangeEvents`.

**NOTE** If an account is not able to connect to the service check the corresponding row in this table.
