using sync.today.io.activities;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.caldav.activities
{
    public sealed class ConvertCalDAVAppointmentToAdapterAppointment : BaseConvertIOAppointmentToAdapterAppointment
    {
        public InArgument<Models.CalDAVEventDTO> CalDAVAppointment { get; set; }
        protected override void DoExecute(System.Activities.CodeActivityContext context)
        {
            devlog.Debug(string.Format("Called on '{0}'and  '{1}'", CalDAVAppointment, AdapterId));
            var myExchangeAppointment = CalDAVAppointment.Get(context);
            var myAdapterId = AdapterId.Get(context);
            devlog.Debug(string.Format("Got '{0}' and  '{1}'", myExchangeAppointment, myAdapterId));
            var dto = Repository.ConvertToDTO(myExchangeAppointment, myAdapterId);
            AdapterAppointment.Set(context, dto);
        }
    }
}
