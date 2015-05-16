using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities.Appointments
{
    public sealed class GetMergeAsWinner : BaseCodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<Models.AdapterAppointmentDTO[]> adapterAppointments { get; set; }
        public OutArgument<Models.AdapterAppointmentDTO> winner { get; set; }
        protected override void DoExecute(CodeActivityContext context)
        {
            devlog.Debug(string.Format("Entered for '{0}'", adapterAppointments));
            var myAdapterAppointments = adapterAppointments.Get(context);
            foreach (var myAdapterAppointment in myAdapterAppointments)
            devlog.Debug(string.Format("Got '{0}'", myAdapterAppointment));
            var result = AdapterAppointmentRepository.merge(myAdapterAppointments);
            devlog.Debug(string.Format("result '{0}'", result));
            winner.Set(context, result);
        }

    }
}

