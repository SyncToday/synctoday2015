using Oak;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDB
{
    public class Schema
    {
        Seed seed;
        public Schema(Seed seed)
        {
            this.seed = seed;
        }

        public IEnumerable<Func<dynamic>> Scripts()
        {
            yield return CreateServiceTable; // Exchange, Flores
            yield return CreateConsumerTable; // David Podhola, Joe Doe
            yield return CreateAccountTable; // David Podhola (user=consumer), Technical account to connect to Flores (not connected to any user/consumer)
            yield return CreateServiceAccountTable; // David Podhola login to Exchange/Office 365; technical connection to Flores
            yield return CreateAdapterTable; // Exchange appointments, Flores activities
            yield return CreateConsumerAdapterTable;
            yield return CreateAppointmentLevelTable;
            yield return CreateJournalTable;
            yield return CreateWorkflowTable;
            yield return CreateProcessTable;
            yield return CreateAppointmentTable;
            yield return CreateAdapterAppointmentTable;
            yield return CreateExchangeAppointmentTable;
            yield return CreateFloresActivityTable;
            yield return CreateGoogleContactTable;
            yield return CreateGoogleAddressTable;
            yield return CreateGooglePhoneNumberTable;
            yield return CreateGoogleEmailTable;
            yield return CreateGoogleGroupTable;
            yield return CreateGoogleGroupMembershipsTable;
        }

        public string CreateAppointmentTable()
        {
            return seed.CreateTable("Appointments",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { LastModified = "datetime", Nullable = false },
                new { Category = "nvarchar(2048)", Nullable = true },

                new { Location = "nvarchar(max)", Nullable = true },
                new { Content = "nvarchar(max)", Nullable = true },
                new { Title = "nvarchar(max)", Nullable = true },
                new { DateFrom = "datetime", Nullable = false },
                new { DateTo = "datetime", Nullable = false },
                new { ReminderMinutesBeforeStart = "int", Nullable = false },
                new { Notification = "bit", Nullable = false },
                new { IsPrivate = "bit", Nullable = false },
                new { Priority = "tinyint", Nullable = false },
                new { ConsumerId = "int", ForeignKey = "Consumers(Id)", Nullable = false }
            );
        }

        public string CreateAdapterAppointmentTable()
        {
            return seed.CreateTable("AdapterAppointments",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { LastModified = "datetime", Nullable = false },
                new { Category = "nvarchar(2048)", Nullable = true },

                new { Location = "nvarchar(max)", Nullable = true },
                new { Content = "nvarchar(max)", Nullable = true },
                new { Title = "nvarchar(max)", Nullable = true },
                new { DateFrom = "datetime", Nullable = false },
                new { DateTo = "datetime", Nullable = false },
                new { ReminderMinutesBeforeStart = "int", Nullable = false },
                new { Notification = "bit", Nullable = false },
                new { IsPrivate = "bit", Nullable = false },
                new { Priority = "tinyint", Nullable = false },
                new { AppointmentId = "int", ForeignKey = "Appointments(Id)", Nullable = false },
                new { AdapterId = "int", ForeignKey = "Adapters(Id)", Nullable = false },
                new { Tag = "int", Nullable = true },
                new { Upload = "bit", Nullable = false, Default = 0 }
            );
        }

        public string CreateJournalTable()
        {
            return seed.CreateTable("Journals",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { Date = "datetime", Nullable = false },
                new { Thread = "nvarchar(255)", Nullable = false },
                new { Level = "nvarchar(50)", Nullable = false },
                new { Logger = "nvarchar(255)", Nullable = false },
                new { Logger_method = "nvarchar(255)", Nullable = false },
                new { Message = "nvarchar(4000)", Nullable = false },
                new { Exception = "nvarchar(max)", Nullable = false },
                new { Stacktrace = "nvarchar(max)", Nullable = false }
            );
        }
        public string CreateWorkflowTable()
        {
            return seed.CreateTable("Workflows",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { CreatedOn = "datetime", Nullable = false },
                new { Name = "nvarchar(255)", Nullable = false },
                new { XamlCode = "nvarchar(max)", Nullable = false }
            );
        }
        public string CreateProcessTable()
        {
            return seed.CreateTable("Processes",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { StartedOn = "datetime", Nullable = false },
                new { FinishedOn = "datetime", Nullable = true },
                new { Name = "nvarchar(255)", Nullable = false },
                new { XamlCode = "nvarchar(max)", Nullable = false },
                new { Exception = "nvarchar(max)", Nullable = true },
                new { WorkflowId = "int", ForeignKey = "Workflows(Id)", Nullable = false }
            );
        }

        public string CreateAdapterTable()
        {
            return seed.CreateTable("Adapters",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { Name = "nvarchar(255)", Nullable = false }
            );
        }

        public string CreateConsumerTable()
        {
            return seed.CreateTable("Consumers",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { Name = "nvarchar(255)", Nullable = false }
            );
        }

        public string CreateConsumerAdapterTable()
        {
            return seed.CreateTable("ConsumerAdapters",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { AdapterId = "int", ForeignKey = "Adapters(Id)", Nullable = false },
                new { ConsumerId = "int", ForeignKey = "Consumers(Id)", Nullable = false },
                new { DateJSON = "nvarchar(max)", Nullable = false }
            );
        }
        
        public string CreateServiceTable()
        {
            return seed.CreateTable("Services",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { Name = "nvarchar(255)", Nullable = false },
                new { Key = "nvarchar(255)", Nullable = false }
            );
        }
        public string CreateAccountTable()
        {
            return seed.CreateTable("Accounts",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { Name = "nvarchar(255)", Nullable = false },
                new { ConsumerId = "int", ForeignKey = "Consumers(Id)", Nullable = true }
            );
        }

        public string CreateAppointmentLevelTable()
        {
            return seed.CreateTable("AppointmentLevels",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { Name = "nvarchar(255)", Nullable = false }
            );
        }
        
        public string CreateServiceAccountTable()
        {
            return seed.CreateTable("ServiceAccounts",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { LoginJSON = "nvarchar(max)", Nullable = false },
                new { ServiceId = "int", ForeignKey = "Services(Id)", Nullable = false },
                new { AccountId = "int", ForeignKey = "Accounts(Id)", Nullable = false },
                new { LastSuccessfulDownload = "datetime", Nullable = true },
                new { LastDownloadAttempt = "datetime", Nullable = true },
                new { LastSuccessfulUpload = "datetime", Nullable = true },
                new { LastUploadAttempt = "datetime", Nullable = true }
            );
        }

        public string CreateGoogleAddressTable()
        {
            return seed.CreateTable("GoogleAddresses",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { ExternalId = "nvarchar(255)", Nullable = true },
                new { City = "nvarchar(max)", Nullable = true },
                new { Street = "nvarchar(max)", Nullable = true },
                new { Region = "nvarchar(max)", Nullable = true },
                new { Postcode = "nvarchar(max)", Nullable = true },
                new { Country = "nvarchar(max)", Nullable = true },
                new { Formatted = "nvarchar(max)", Nullable = true },
                new { Label = "nvarchar(max)", Nullable = true },
                new { Usage = "nvarchar(max)", Nullable = true },
                new { ContactId = "int", ForeignKey = "GoogleContacts(Id)", Nullable = false }
            );

        }

        public string CreateGoogleEmailTable()
        {
            return seed.CreateTable("GoogleEmails",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { ExternalId = "nvarchar(255)", Nullable = true },
                new { Address = "nvarchar(max)", Nullable = true },
                new { Label = "nvarchar(max)", Nullable = true },
                new { Home = "bit", Nullable = true },
                new { Other = "bit", Nullable = true },
                new { Work = "bit", Nullable = true },
                new { ContactId = "int", ForeignKey = "GoogleContacts(Id)", Nullable = false }
            );

        }

        public string CreateGooglePhoneNumberTable()
        {
            return seed.CreateTable("GooglePhoneNumbers",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { ExternalId = "nvarchar(255)", Nullable = true },
                new { Value = "nvarchar(max)", Nullable = true },
                new { Label = "nvarchar(max)", Nullable = true },
                new { Home = "bit", Nullable = true },
                new { Other = "bit", Nullable = true },
                new { Work = "bit", Nullable = true },
                new { ContactId = "int", ForeignKey = "GoogleContacts(Id)", Nullable = false }
            );

        }

        public string CreateGoogleGroupTable()
        {
            return seed.CreateTable("GoogleGroups",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { ExternalId = "nvarchar(255)", Nullable = true },
                new { ChangedOn = "datetime", Nullable = false },
                new { Title = "nvarchar(max)", Nullable = false }
            );
        }

        public string CreateGoogleGroupMembershipsTable()
        {
            return seed.CreateTable("GoogleGroupMemberships",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { ExternalId = "nvarchar(255)", Nullable = true },
                new { ChangedOn = "datetime", Nullable = false },
                new { ContactId = "int", ForeignKey = "GoogleContacts(Id)", Nullable = false },
                new { GroupId = "int", ForeignKey = "GoogleGroups(Id)", Nullable = false }
            );
        }

        public string CreateGoogleContactTable()
        {
            return seed.CreateTable("GoogleContacts",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { ExternalId = "nvarchar(255)", Nullable = true },
                new { ChangedOn = "datetime", Nullable = false },
                new { Content = "nvarchar(max)", Nullable = false },
                new { Title = "nvarchar(max)", Nullable = false },
                new { Email = "nvarchar(255)", Nullable = true },

                new { GivenName = "nvarchar(max)", Nullable = true },
                new { FamilyName = "nvarchar(max)", Nullable = true },
                new { OrgDepartment = "nvarchar(max)", Nullable = true },
                new { OrgJobDescription = "nvarchar(max)", Nullable = true },
                new { OrgName = "nvarchar(max)", Nullable = true },
                new { OrgTitle = "nvarchar(max)", Nullable = true },
                new { PrimaryPhonenumber = "nvarchar(max)", Nullable = true },
                new { postalAddressCity = "nvarchar(max)", Nullable = true },
                new { postalAddressStreet = "nvarchar(max)", Nullable = true },
                new { postalAddressRegion = "nvarchar(max)", Nullable = true },
                new { postalAddressPostcode = "nvarchar(max)", Nullable = true },
                new { postalAddressCountry = "nvarchar(max)", Nullable = true },
                new { postalAddressFormattedAddress = "nvarchar(max)", Nullable = true },

                new { Upload = "bit", Nullable = false, Default = 0 },
                new { Tag = "int", Nullable = true },
                new { IsNew = "bit", Nullable = false, Default = 0 },
                new { WasJustUpdated = "bit", Nullable = false, Default = 0 },
                new { LastDLError = "nvarchar(max)", Nullable = true },
                new { LastUPError = "nvarchar(max)", Nullable = true }
            );

        }

        public string CreateFloresActivityTable()
        {
            return seed.CreateTable("FloresActivities",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { ExternalId = "nvarchar(255)", Nullable = true },
                new { RealEndDate = "datetime", Nullable = false },
                new { CorrectedDATE = "datetime", Nullable = false },
                new { Description = "nvarchar(max)", Nullable = false },
                new { SheduledStartDate = "datetime", Nullable = false },
                new { Subject = "nvarchar(max)", Nullable = false },
                new { RealStartDate = "datetime", Nullable = false },
                new { ActivityType_ID = "nvarchar(255)", Nullable = true },
                new { SheduledEndDate = "datetime", Nullable = false },
                new { ResponsibleUser_ID = "nvarchar(255)", Nullable = true },
                new { Period_ID = "nvarchar(255)", Nullable = true },
                new { Status_ID = "nvarchar(255)", Nullable = true },
                new { Division_ID = "nvarchar(255)", Nullable = true },
                new { Firm_ID = "nvarchar(255)", Nullable = true },
                new { Person_ID = "nvarchar(255)", Nullable = true },
                new { OutlookCategory_ID = "nvarchar(255)", Nullable = true },
                new { FirmOffice_Address = "nvarchar(max)", Nullable = true },
                new { Firm_Address = "nvarchar(max)", Nullable = true },

                new { Upload = "bit", Nullable = false, Default = 0 }, 
                
                new { Tag = "int", Nullable = true },

                new { IsNew = "bit", Nullable = false, Default = 0 },
                new { WasJustUpdated = "bit", Nullable = false, Default = 0 },

                new { LastDLError = "nvarchar(max)", Nullable = true },
                new { LastUPError = "nvarchar(max)", Nullable = true }

            );
        }
        public string CreateExchangeAppointmentTable()
        {
            return seed.CreateTable("ExchangeAppointments",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { ExternalId = "nvarchar(2048) COLLATE SQL_Latin1_General_CP1_CS_AS", Nullable = true }, // _eventPropertySetAll.Add(AppointmentSchema.Id);                
                new { Body = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.Body);
                new { Start = "datetime", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.Start);
                new { End = "datetime", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.End);
                new { LastModifiedTime = "datetime", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.LastModifiedTime);
                new { Location = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.Location);
                new { IsReminderSet = "bit", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.IsReminderSet);
                new { AppointmentState = "tinyint", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.AppointmentState);
                new { Subject = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.Subject);
                new { RequiredAttendeesJSON = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.RequiredAttendees);
                new { ReminderMinutesBeforeStart = "int", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.ReminderMinutesBeforeStart);
                new { Sensitivity = "tinyint", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.Sensitivity);
                new { RecurrenceJSON = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.Recurrence);
                new { ModifiedOccurrencesJSON = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.ModifiedOccurrences);
                new { LastOccurrenceJSON = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.LastOccurrence);
                new { IsRecurring = "bit", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.IsRecurring);
                new { IsCancelled = "bit", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.IsCancelled);
                new { ICalRecurrenceId = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.ICalRecurrenceId);
                new { FirstOccurrenceJSON = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.FirstOccurrence);
                new { DeletedOccurrencesJSON = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.DeletedOccurrences);
                new { AppointmentType = "tinyint", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.AppointmentType);
                new { Duration = "int", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.Duration);

                new { StartTimeZone = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.StartTimeZone);
                new { EndTimeZone = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.EndTimeZone);
                
                new { AllowNewTimeProposal = "bit", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.AllowNewTimeProposal);
                new { CategoriesJSON = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.Categories);

                new { ServiceAccountId = "int", ForeignKey = "ServiceAccounts(Id)", Nullable = false },
                new { Upload = "bit", Nullable = false, Default = 0 }, 
                
                new { Tag = "int", Nullable = true },

                new { IsNew = "bit", Nullable = false, Default = 0 }, 
                new { WasJustUpdated = "bit", Nullable = false, Default = 0 },

                new { DownloadRound = "int", Nullable = false, Default = 0 },

                new { LastDLError = "nvarchar(max)", Nullable = true }, 
                new { LastUPError = "nvarchar(max)", Nullable = true }


            );
        }


    }
}
