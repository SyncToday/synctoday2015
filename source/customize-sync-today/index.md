@{
    Layout = "page";
    Title = "Customize Sync.Today";
    Date = "2016-02-03T08:35:43";
    Tags = "";
    Description = "";
}

Making customizations easier than in Sync.Today 2013 was one of the most important requirements for Sync.Today 2015. You can customize several aspects of the synchronization.

### The synchronization algorithm
When you run `sync.today.temp.workflowapp` to actually do the synchronization, you pass the synchronization algorithm identification (assembly-qualified name usable in `Type.GetType`) as the only parameter. 
The synchronization algorithm is expected to be inheriting `System.Activities.Activity` class.

#### The default synchronization algorithm
The default synchronization algorithm (`"FloresExchangeMerge.sync.today.temp.workflow.,sync.today.temp.workflow"`) , has those stages:

1. **Iterate through service accounts** (logins, connections) - For each service account adapter downloads the specific data to the specific tables (e.g. `ExchangeAppointments`)
2. **Transform through adapters** (tranformations) - Transform workflows (e.g. `TransformExchange`) run on adapter data: **Updates** `AdapterAppointments` and **Creates** new `Appointments` if necessary
3. **Synchronize through consumers** (users) - Make sure all appointments are correctly in all adapters. Find winners and update `Appointments` and `AdapterAppointments`
4. **Transform back through adapters** - Transform workflows (e.g. `Transform2CalDAV`) run on adapter data: **Updates** `AdapterAppointments` and **Creates** new `Appointments` if necessary
5. **Iterate back throught service accounts** - For each service account adapter uploads data from the specific tables (e.g. `ExchangeAppointments`) to the service

#### Creating custom synchronization algorithm
The easiest way to create custom Activity class (the synchronization algorithm) is to create an Activity Library in Visual Studio.
There is an empty `Activity` created in the Activity Library project. 
Use the toolbox to model the algorithm. You can use your custom activities or the built-in Sync.Today 2015 activities referencing assemblies with `.activities` 
in the name e.g. `sync.today.activities` for the basic activities like `GetServiceAccountByAdapterAndConsumer`.

### Creating custom adapter
Adapters are used to download and upload the service specific entities to the custom tables (e.g. `ExchangeAppointments`) in Sync.Today database and transform them to standard entities (e.g. `Appointments`).
When creating custom adapter to connect to a new service, you need to create a managed assembly (e.g. C# or F# class library) containing the code. 
Depending on the entities used you need to reference the assemblies defining the synchronized types e.g. `sync.today.ent.calendar` for synchronizing the calendar items (events, meetings).

### Creating custom activities
Creating custom activities for a custom adapter is very similar to creating your own synchronization algorithm, again the Activity Library with activities needs to be created.
