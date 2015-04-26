using sync.today.io.activities;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.caldav.activities
{
    public sealed class GetNewCalDAVAppointments : GetNewIOAppointments
    {
        public InArgument<Models.CalDAVEventDTO[]> AlsoIncludedAppointments { get; set; }
        public OutArgument<Models.CalDAVEventDTO[]> NewAppointments { get; set; }
        protected override void DoExecute(CodeActivityContext context)
        {
            var alsoIncluded = AlsoIncludedAppointments.Get(context);
            devlog.DebugFormat("alsoIncluded.Length:'{0}'", alsoIncluded.Length);
            var newAppsList = new List<Models.CalDAVEventDTO>(Repository.NewEvents());
            devlog.DebugFormat("newAppsList.Count:'{0}'", newAppsList.Count);
            newAppsList.AddRange(alsoIncluded);
            var newApps = newAppsList.ToArray();
            devlog.DebugFormat("newApps.Length:'{0}'", newApps.Length);
            NewAppointments.Set(context, newApps);
        }

    }
}
