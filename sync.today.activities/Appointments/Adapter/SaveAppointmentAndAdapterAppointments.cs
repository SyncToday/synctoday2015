using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities.Appointments.Adapter
{
    public sealed class SaveAppointmentAndAdapterAppointments : CodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<Models.AppointmentDTO> appointment { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            try
            {
                log.Debug(string.Format("Entered for '{0}'", appointment));
                var myAppointment = appointment.Get<Models.AppointmentDTO>(context);
                log.Debug(string.Format("would call for '{0}'", myAppointment));
                AdapterAppointmentRepository.CopyAndSaveAllFrom(myAppointment);
                AppointmentRepository.InsertOrUpdate(myAppointment);
            }
            catch (Exception ex)
            {
                log.Fatal("failed", ex);
                throw;
            }
        }

    }
}