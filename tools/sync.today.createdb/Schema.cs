using Oak;
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
            yield return CreateJournalTable;
            yield return CreateWorkflowTable;
            yield return CreateProcessTable;
            yield return CreateAppointmentTable;
        }

        public string CreateAppointmentTable()
        {
            return seed.CreateTable("Appointments",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { ExternalId = "nvarchar(2048)", Nullable = true },
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
    }
}
