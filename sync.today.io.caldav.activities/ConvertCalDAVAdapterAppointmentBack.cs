using sync.today.io.activities;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.caldav.activities
{
    public sealed class ConvertCalDAVAdapterAppointmentBack : BaseConvertIOAdapterAppointmentBack
    {
        public InArgument<Models.CalDAVEventDTO> OriginalCalDAVAppointment { get; set; }
        public OutArgument<Models.CalDAVEventDTO> CalDAVAppointment { get; set; }

        protected override void DoExecute(System.Activities.CodeActivityContext context)
        {
            devlog.Debug(string.Format("Called on '{0}'and  '{1}'", AdapterAppointment, ServiceAccountId));
            var myAdapterAppointment = AdapterAppointment.Get(context);
            var myServiceAccountId = ServiceAccountId.Get(context);
            var myOriginalAppointment = OriginalCalDAVAppointment.Get(context);
            devlog.Debug(string.Format("Got '{0}' and  '{1}' and '{2}'", myAdapterAppointment, myServiceAccountId, myOriginalAppointment));
            var Appointment = Repository.ConvertFromDTO(myAdapterAppointment, myServiceAccountId, myOriginalAppointment);
            CalDAVAppointment.Set(context, Appointment);
        }
    }
}
