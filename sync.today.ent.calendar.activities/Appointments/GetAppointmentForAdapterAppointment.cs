using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities.Appointments
{
    public sealed class GetAppointmentForAdapterAppointment : BaseCodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<Models.AdapterAppointmentDTO> adapterAppointment { get; set; }
        public OutArgument<Models.AppointmentDTO> appointment { get; set; }
        protected override void DoExecute(CodeActivityContext context)
        {
            devlog.Debug(string.Format("Entered for '{0}'", adapterAppointment));
            Models.AdapterAppointmentDTO myADA = adapterAppointment.Get(context);
            devlog.Debug(string.Format("Gor for '{0}'", myADA));
            Models.AppointmentDTO app = AppointmentRepository.GetAppointmentByAdapterAppointmentId(myADA.Id).Value;
            appointment.Set(context, app);
        }

    }
}
