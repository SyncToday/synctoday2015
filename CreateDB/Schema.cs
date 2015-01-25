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
        }

        public string CreateJournalTable()
        {
            return seed.CreateTable("Journals",
                new { Id = "int", Identity = true, PrimaryKey = true },
                new { Date = "datetime" },
                new { Thread = "nvarchar(max)" },
                new { Level = "nvarchar(max)" },
                new { Logger = "nvarchar(max)" },
                new { Logger_method = "nvarchar(max)" },
                new { Message = "nvarchar(max)" },
                new { Exception = "nvarchar(max)" },
                new { Stacktrace = "nvarchar(max)" }
            );
        }
    }
}
