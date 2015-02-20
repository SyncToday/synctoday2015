using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities.Appointments.Adapter
{
    public sealed class GetAdapterAppointments : CodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<Models.AppointmentDTO> appointment { get; set; }
        public OutArgument<Models.AdapterAppointmentDTO[]> adapterAppointments { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            log.Debug(string.Format("Entered for '{0}'", appointment));
            try
            {
                var myAppointment = appointment.Get<Models.AppointmentDTO>(context);
                log.Debug(string.Format("would call for '{0}'", myAppointment));
                var journalItems = AdapterAppointmentRepository.AdapterAppointments(myAppointment.Id);
                List<Models.AdapterAppointmentDTO> resultItems = new List<Models.AdapterAppointmentDTO>(journalItems);
                adapterAppointments.Set(context, resultItems.ToArray());
            }
            catch (Exception ex)
            {
                log.Fatal("failed", ex);
                throw;
            }
        }

    }
}
