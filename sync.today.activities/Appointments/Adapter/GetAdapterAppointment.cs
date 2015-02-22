using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities.Appointments.Adapter
{
    public sealed class GetAdapterAppointment : CodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public InArgument<Guid> InternalId { get; set; }
        public OutArgument<Models.AdapterAppointmentDTO> appointment { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            log.Debug(string.Format("Entered for '{0}'", InternalId));
            try
            {
                var myInternalId = InternalId.Get(context);
                log.Debug(string.Format("would call for '{0}'", myInternalId));
                var app = AdapterAppointmentRepository.Get(myInternalId);
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
