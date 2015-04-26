using sync.today.io.activities;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.caldav.activities
{
    public sealed class GetCalDAVEventByInternalId : BaseGetIOAppointmentByInternalId
    {
        public OutArgument<Models.CalDAVEventDTO> CalDAVEvent { get; set; }
        protected override void DoExecute(System.Activities.CodeActivityContext context)
        {
            var internalId = InternalId.Get(context);
            devlog.DebugFormat("Entered for '{0}'", internalId);
            var found = Repository.EventByInternalId(internalId);
            try
            {
                CalDAVEvent.Set(context, found.Value);
                devlog.DebugFormat("found '{0}'", found.Value);
            }
            catch (NullReferenceException)
            {
                CalDAVEvent.Set(context, null);
                devlog.DebugFormat("found nothing");
            }
        }
    }
}
