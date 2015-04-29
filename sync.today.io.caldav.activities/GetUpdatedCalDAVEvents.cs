using sync.today.io.activities;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.caldav.activities
{
    public sealed class GetUpdatedCalDAVEvents : GetUpdatedIOAppointments
    {
        public OutArgument<Models.CalDAVEventDTO[]> UpdatedAppointments { get; set; }
        protected override void DoExecute(CodeActivityContext context)
        {
            devlog.Debug("Entered");
            var result = Repository.UpdatedEvents();
            var updatedApps = new List<Models.CalDAVEventDTO>(result).ToArray();
            devlog.DebugFormat("updatedApps.Length:'{0}'", updatedApps.Length);
            UpdatedAppointments.Set(context, updatedApps);
        }

    }
}
