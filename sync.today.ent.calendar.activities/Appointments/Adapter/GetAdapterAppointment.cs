using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities.Appointments.Adapter
{
    public sealed class GetAdapterAppointment : BaseCodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public InArgument<Guid> InternalId { get; set; }
        public InArgument<Models.AdapterDTO> Adapter { get; set; }
        public OutArgument<Models.AdapterAppointmentDTO> appointment { get; set; }
        protected override void DoExecute(CodeActivityContext context)
        {
            var myInternalId = InternalId.Get(context);
            var myAdapter = Adapter.Get(context);
            devlog.Debug(string.Format("would call for '{0}' and '{1}'", myInternalId, myAdapter));
            var app = AdapterAppointmentRepository.Get(myInternalId, myAdapter.Id);
            devlog.Debug(string.Format("found '{0}'", app));
            try
            {
                appointment.Set(context, app.Value);
            }
            catch (NullReferenceException)
            {
                appointment.Set(context, null);
            }
        }

    }
}
