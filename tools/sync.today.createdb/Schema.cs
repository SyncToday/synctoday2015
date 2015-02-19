﻿using Oak;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDB
{
    class Schema
    {
        Seed seed;
        internal Schema(Seed seed)
        {
            this.seed = seed;
        }

        public IEnumerable<Func<dynamic>> Scripts()
        {
            yield return CreateServiceTable; // Exchange
            yield return CreateAccountTable; // David Podhola on Office 365
            yield return CreateServiceAccountTable; // David Podhola login to Exchange/Office 365
            yield return CreateAdapterTable; // Exchange appointments
            yield return CreateJournalTable;
            yield return CreateWorkflowTable;
            yield return CreateProcessTable;
            yield return CreateAppointmentTable;
            yield return CreateAdapterAppointmentTable;
            yield return CreateExchangeAppointmentTable;
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
                new { Reminder = "datetime", Nullable = true },
                new { Notification = "bit", Nullable = false },
                new { IsPrivate = "bit", Nullable = false },
                new { Priority = "tinyint", Nullable = false }                
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
                new { Reminder = "datetime", Nullable = true },
                new { Notification = "bit", Nullable = false },
                new { IsPrivate = "bit", Nullable = false },
                new { Priority = "tinyint", Nullable = false },
                new { AppointmentId = "int", ForeignKey = "Appointments(Id)", Nullable = false },
                new { AdapterId = "int", ForeignKey = "Adapters(Id)", Nullable = false },
                new { ServiceAccountId = "int", ForeignKey = "ServiceAccounts(Id)", Nullable = false },
                new { Tag = "int", Nullable = true }
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
                new { Name = "nvarchar(255)", Nullable = false },
                new { ServiceId = "int", ForeignKey = "Services(Id)", Nullable = false }
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
                new { LastDownload = "datetime", Nullable = true }
            );
        }
        public string CreateExchangeAppointmentTable()
        {
            return seed.CreateTable("ExchangeAppointments",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { InternalId = "uniqueidentifier", Nullable = false, Default = "newid()" },
                new { ExternalId = "nvarchar(2048)", Nullable = true }, // _eventPropertySetAll.Add(AppointmentSchema.Id);                
                new { Body = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.Body);
                new { Start = "datetime", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.Start);
                new { End = "datetime", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.End);
                new { LastModifiedTime = "datetime", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.LastModifiedTime);
                new { Location = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.Location);
                new { IsReminderSet = "bit", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.IsReminderSet);
                new { ReminderDueBy = "datetime", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.ReminderDueBy);
                new { AppointmentState = "tinyint", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.AppointmentState);
                new { Subject = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.Subject);
                new { RequiredAttendeesJSON = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.RequiredAttendees);
                new { ReminderMinutesBeforeStart = "int", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.ReminderMinutesBeforeStart);
                new { Sensitivity = "tinyint", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.Sensitivity);
                new { RecurrenceJSON = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.Recurrence);
                new { ModifiedOccurrencesJSON = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.ModifiedOccurrences);
                new { LastOccurrence = "datetime", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.LastOccurrence);
                new { IsRecurring = "bit", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.IsRecurring);
                new { IsCancelled = "bit", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.IsCancelled);
                new { ICalRecurrenceId = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.ICalRecurrenceId);
                new { FirstOccurrence = "datetime", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.FirstOccurrence);
                new { DeletedOccurrencesJSON = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.DeletedOccurrences);
                new { AppointmentType = "tinyint", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.AppointmentType);
                new { Duration = "int", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.Duration);

                new { StartTimeZone = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.StartTimeZone);
                new { EndTimeZone = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.EndTimeZone);
                
                new { AllowNewTimeProposal = "bit", Nullable = false }, //_eventPropertySetAll.Add(AppointmentSchema.AllowNewTimeProposal);
                new { CategoriesJSON = "nvarchar(max)", Nullable = true }, //_eventPropertySetAll.Add(AppointmentSchema.Categories);

                new { ServiceAccountId = "int", ForeignKey = "ServiceAccounts(Id)", Nullable = false },
                
                new { Tag = "int", Nullable = true }
            );
        }


    }
}
