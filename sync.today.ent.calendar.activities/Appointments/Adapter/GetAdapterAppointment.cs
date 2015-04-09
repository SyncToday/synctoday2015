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
            log.Debug(string.Format("Entered for '{0}' and '{1}'", InternalId, Adapter));
            try
            {
                var myInternalId = InternalId.Get(context);
                var myAdapter = Adapter.Get(context);
                log.Debug(string.Format("would call for '{0}' and '{1}'", myInternalId, myAdapter));
                var app = AdapterAppointmentRepository.Get(myInternalId, myAdapter.Id);
                log.Debug(string.Format("found '{0}'", app));
                try
                {
                    appointment.Set(context, app.Value);
                }
                catch (NullReferenceException)
                {
                    appointment.Set(context, null);
                }
            }
            catch (Exception ex)
            {
                log.Fatal("failed", ex);
                throw;
            }
        }

    }
}
