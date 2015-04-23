using sync.today.io.activities;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.caldav.activities
{
    public sealed class ChangeInternalIdBecauseOfDuplicity : BaseChangeInternalIdBecauseOfDuplicity
    {
        public InArgument<Models.CalDAVEventDTO> Appointment { get; set; }
        protected override void DoExecute(CodeActivityContext context)
        {
            devlog.Debug(string.Format("Called on '{0}'and  '{1}'", Appointment, FoundDuplicity));
            var myAppointment = Appointment.Get(context);
            var myFoundDuplicity = FoundDuplicity.Get(context);
            devlog.Debug(string.Format("Got '{0}' and  '{1}'", myAppointment, myFoundDuplicity));
            Repository.ChangeInternalIdBecauseOfDuplicity(myAppointment, myFoundDuplicity);
        }
    }
}
