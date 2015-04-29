using sync.today.io.activities;
using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.io.caldav.activities
{
    public sealed class SaveCalDAVEvent : SaveIOAppointment
    {
        public InArgument<Models.CalDAVEventDTO> CalDAVEvent { get; set; }
        protected override void DoExecute(CodeActivityContext context)
        {
            devlog.Debug(string.Format("Called on '{0}'", CalDAVEvent));
            var myAppointment = CalDAVEvent.Get(context);
            devlog.Debug(string.Format("myExchangeAppointment:'{0}'", myAppointment));
            Repository.save(myAppointment, myAppointment.ServiceAccountId);
        }

    }
}
