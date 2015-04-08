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
            yield return CreateExchangeContactTable;
            yield return CreateExchangeEmailMessagesTable;
            yield return CreateFloresActivityTable;
            yield return CreateFloresPersonTable;
            yield return CreateFloresFirmTable;
            yield return CreateGoogleContactTable;
            yield return CreateGoogleAddressTable;
            yield return CreateGooglePhoneNumberTable;
            yield return CreateGoogleEmailTable;
            yield return CreateGoogleGroupTable;
            yield return CreateGoogleGroupMembershipsTable;
            yield return CreateProductTable;
            yield return CreateCustomerCategoryTable;
            yield return CreateCustomerTable;
            yield return CreateProductCategoryTable;
            yield return CreateProductCategoryMembershipTable;
            yield return CreateProductSoldToCustomerTable;
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

        public string CreateProductSoldToCustomerTable()
        {
            return seed.CreateTable("ProductSoldToCustomers",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { LastModified = "datetime", Nullable = false },
                new { Category = "nvarchar(2048)", Nullable = true },

                new { ProductId = "int", ForeignKey = "Products(Id)", Nullable = false },
                new { CustomerId = "int", ForeignKey = "Customers(Id)", Nullable = false },
                new { SoldWhen = "datetime", Nullable = false },
                new { UnitPrice = "decimal", Nullable = false },
                new { Units = "decimal", Nullable = false }
            );
        }

        public string CreateProductCategoryMembershipTable()
        {
            return seed.CreateTable("ProductCategoryMemberships",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { LastModified = "datetime", Nullable = false },
                new { Category = "nvarchar(2048)", Nullable = true },

                new { ProductId = "int", ForeignKey = "Products(Id)", Nullable = false },
                new { ProductCategoryId = "int", ForeignKey = "ProductCategories(Id)", Nullable = false }
            );
        }

        public string CreateProductTable()
        {
            return seed.CreateTable("Products",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { LastModified = "datetime", Nullable = false },
                new { Category = "nvarchar(2048)", Nullable = true },

                new { Name = "nvarchar(max)", Nullable = false },
                new { Description = "nvarchar(max)", Nullable = true },
                new { Code = "nvarchar(255)", Nullable = true }
            );
        }
        public string CreateProductCategoryTable()
        {
            return seed.CreateTable("ProductCategories",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { LastModified = "datetime", Nullable = false },
                new { Category = "nvarchar(2048)", Nullable = true },

                new { Name = "nvarchar(max)", Nullable = false },
                new { Description = "nvarchar(max)", Nullable = true },
                new { Code = "nvarchar(255)", Nullable = true }
            );
        }
        public string CreateCustomerCategoryTable()
        {
            return seed.CreateTable("CustomerCategories",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { LastModified = "datetime", Nullable = false },
                new { Category = "nvarchar(2048)", Nullable = true },

                new { Name = "nvarchar(max)", Nullable = false },
                new { Description = "nvarchar(max)", Nullable = true },
                new { Code = "nvarchar(255)", Nullable = true }
            );
        }

        public string CreateCustomerTable()
        {
            return seed.CreateTable("Customers",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { LastModified = "datetime", Nullable = false },
                new { Category = "nvarchar(2048)", Nullable = true },

                new { Name = "nvarchar(max)", Nullable = false },
                new { Code = "nvarchar(255)", Nullable = true },
                new { CustomerCategoryId = "int", ForeignKey = "CustomerCategories(Id)", Nullable = false }                
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

        public string CreateFloresPersonTable()
        {
            return seed.CreateTable("FloresPersons",
                // ALWAYS HERE FOR Flores
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { ExternalId = "nvarchar(255)", Nullable = true },
                new { CorrectedDATE = "datetime", Nullable = false },


                new { LastName = "nvarchar(max)", Nullable = false },
                new { FirstName = "nvarchar(max)", Nullable = false },
                new { Title = "nvarchar(max)", Nullable = false },
                new { Grade = "nvarchar(max)", Nullable = false },
                new { ExternalText = "nvarchar(max)", Nullable = false },
                new { InternalText = "nvarchar(max)", Nullable = false },
                new { Category = "nvarchar(max)", Nullable = false },
                new { ResponsibleUser_ID = "nvarchar(255)", Nullable = false },
                new { ResponsibleRole_ID = "nvarchar(255)", Nullable = false },
                new { Status_ID = "nvarchar(255)", Nullable = false },
                new { Suffix = "nvarchar(max)", Nullable = false },
                new { CRMMenuItem_ID = "nvarchar(255)", Nullable = false },
                new { Recipient = "nvarchar(max)", Nullable = false },
                new { City = "nvarchar(max)", Nullable = false },
                new { Street = "nvarchar(max)", Nullable = false },
                new { PostCode = "nvarchar(max)", Nullable = false },
                new { ZIP = "nvarchar(max)", Nullable = false },
                new { Country = "nvarchar(max)", Nullable = false },
                new { PhoneNumber1 = "nvarchar(max)", Nullable = false },
                new { PhoneNumber2 = "nvarchar(max)", Nullable = false },
                new { FaxNumber = "nvarchar(max)", Nullable = false },
                new { EMail = "nvarchar(max)", Nullable = false },
                new { Location = "nvarchar(max)", Nullable = false },
                new { CountryCode = "nvarchar(max)", Nullable = false },

                // ALWAYS PRESENT
                new { Upload = "bit", Nullable = false, Default = 0 },

                new { Tag = "int", Nullable = true },

                new { IsNew = "bit", Nullable = false, Default = 0 },
                new { WasJustUpdated = "bit", Nullable = false, Default = 0 },

                new { LastDLError = "nvarchar(max)", Nullable = true },
                new { LastUPError = "nvarchar(max)", Nullable = true }

            );
        }

        public string CreateFloresFirmTable()
        {
            return seed.CreateTable("FloresFirms",
                // ALWAYS HERE FOR Flores
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { ExternalId = "nvarchar(255)", Nullable = true },
                new { CorrectedDATE = "datetime", Nullable = false },


                new { Name = "nvarchar(max)", Nullable = false },
                new { VATIdentNumber = "nvarchar(max)", Nullable = false },
                new { WWWAddress = "nvarchar(max)", Nullable = false },
                new { ReceivedInvoicesSum = "money", Nullable = false },
                new { IssuedInvoicesSum = "money", Nullable = false },
                new { Recipient = "nvarchar(max)", Nullable = false },
                new { City = "nvarchar(max)", Nullable = false },
                new { Street = "nvarchar(max)", Nullable = false },
                new { PostCode = "nvarchar(max)", Nullable = false },
                new { ZIP = "nvarchar(max)", Nullable = false },
                new { Country = "nvarchar(max)", Nullable = false },
                new { PhoneNumber1 = "nvarchar(max)", Nullable = false },
                new { PhoneNumber2 = "nvarchar(max)", Nullable = false },
                new { FaxNumber = "nvarchar(max)", Nullable = false },
                new { EMail = "nvarchar(max)", Nullable = false },
                new { Location = "nvarchar(max)", Nullable = false },
                new { CountryCode = "nvarchar(max)", Nullable = false },

                // ALWAYS PRESENT
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

        public string CreateExchangeEmailMessagesTable()
        {

            return seed.CreateTable("ExchangeEmailMessages",
                /* THIS IS ALWAYS PRESENT */
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { ExternalId = "nvarchar(2048) COLLATE SQL_Latin1_General_CP1_CS_AS", Nullable = true }, // _eventPropertySetAll.Add(ContactSchema.Id);                
                new { LastModifiedTime = "datetime", Nullable = false }, //_eventPropertySetAll.Add(ContactSchema.LastModifiedTime);

                // ExchangeEmailMessage
                new { MailSubject = "nvarchar(max)", Nullable = true },
                new { Body = "nvarchar(max)", Nullable = true },
                new { BccRecipientsJSON = "nvarchar(max)", Nullable = true },
                new { CcRecipientsJSON = "nvarchar(max)", Nullable = true },
                new { Sender = "nvarchar(max)", Nullable = true },
                new { InternetMessageId = "nvarchar(max)", Nullable = true },
                new { ReceivedByJSON = "nvarchar(max)", Nullable = true },
                new { ReceivedRepresentingJSON = "nvarchar(max)", Nullable = true },
                new { MailReferences = "nvarchar(max)", Nullable = true },
                new { ReplyToJSON = "nvarchar(max)", Nullable = true },
                new { SenderJSON = "nvarchar(max)", Nullable = true },
                new { ToRecipientsJSON = "nvarchar(max)", Nullable = true },

                // ExchangeEmailMessage

                new { CategoriesJSON = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(ContactSchema.Categories);

                /* THIS IS ALWAYS PRESENT */
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

        public string CreateExchangeContactTable()
        {
            return seed.CreateTable("ExchangeContacts",
                /* THIS IS ALWAYS PRESENT */
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { ExternalId = "nvarchar(2048) COLLATE SQL_Latin1_General_CP1_CS_AS", Nullable = true }, // _eventPropertySetAll.Add(ContactSchema.Id);                
                new { LastModifiedTime = "datetime", Nullable = false }, //_eventPropertySetAll.Add(ContactSchema.LastModifiedTime);

                new { JobTitle = "nvarchar(max)", Nullable = true },
                new { CompanyName = "nvarchar(max)", Nullable = true },
                new { EmailAddress1 = "nvarchar(max)", Nullable = true },
                new { EmailAddress2 = "nvarchar(max)", Nullable = true },
                new { EmailAddress3 = "nvarchar(max)", Nullable = true },
                new { GivenName = "nvarchar(max)", Nullable = true },
                new { MiddleName = "nvarchar(max)", Nullable = true },
                new { Surname = "nvarchar(max)", Nullable = true },
                new { Alias = "nvarchar(max)", Nullable = true },
                new { NickName = "nvarchar(max)", Nullable = true },
                new { HomePhone = "nvarchar(max)", Nullable = true },
                new { MobilePhone = "nvarchar(max)", Nullable = true },
                new { BusinessPhone = "nvarchar(max)", Nullable = true },
                new { PrimaryPhone = "nvarchar(max)", Nullable = true },
                new { OtherTelephone = "nvarchar(max)", Nullable = true },
                new { HomeAddressCity = "nvarchar(max)", Nullable = true },
                new { HomeAddressCountryOrRegion = "nvarchar(max)", Nullable = true },
                new { HomeAddressPostalCode = "nvarchar(max)", Nullable = true },
                new { HomeAddressState = "nvarchar(max)", Nullable = true },
                new { HomeAddressStreet = "nvarchar(max)", Nullable = true },
                new { OtherAddressCity = "nvarchar(max)", Nullable = true },
                new { OtherAddressPostalCode = "nvarchar(max)", Nullable = true },
                new { OtherAddressCountryOrRegion = "nvarchar(max)", Nullable = true },
                new { OtherAddressState = "nvarchar(max)", Nullable = true },
                new { OtherAddressStreet = "nvarchar(max)", Nullable = true },
                new { BusinessAddressCity = "nvarchar(max)", Nullable = true },
                new { BusinessAddressCountryOrRegion = "nvarchar(max)", Nullable = true },
                new { BusinessAddressState = "nvarchar(max)", Nullable = true },
                new { BusinessAddressStreet = "nvarchar(max)", Nullable = true },
                new { BusinessAddressPostalCode = "nvarchar(max)", Nullable = true },

                new { CategoriesJSON = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(ContactSchema.Categories);

                /* THIS IS ALWAYS PRESENT */
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
