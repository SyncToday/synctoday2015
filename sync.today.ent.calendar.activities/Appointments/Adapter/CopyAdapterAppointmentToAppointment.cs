using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities.Appointments.Adapter
{
    public sealed class CopyAdapterAppointmentToAppointment : BaseCodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<Models.ConsumerDTO> Consumer { get; set; }
        public InArgument<Models.AdapterAppointmentDTO> AdapterAppointment { get; set; }
        public InOutArgument<Models.AppointmentDTO> Appointment { get; set; }
        protected override void DoExecute(CodeActivityContext context)
        {
            devlog.Debug(string.Format("Entered for '{0}' and '{1}' and '{2}'", Appointment, AdapterAppointment, Consumer));
            var myAppointment = Appointment.Get(context);
            var myAdapterAppointment = AdapterAppointment.Get(context);
            var myConsumer = Consumer.Get(context);
            devlog.Debug(string.Format("would call for '{0}' and '{1}' and '{2}'", myAppointment, myAdapterAppointment, myConsumer));

            Appointment.Set(context, AdapterAppointmentRepository.copyAdapterAppointmentToAppointment(myAdapterAppointment, myAppointment));
        }

    }
}
