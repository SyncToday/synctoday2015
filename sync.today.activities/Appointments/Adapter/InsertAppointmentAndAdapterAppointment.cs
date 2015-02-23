using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities.Appointments.Adapter
{
    public sealed class InsertAppointmentAndAdapterAppointment : CodeActivity
      {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<Models.AdapterAppointmentDTO> adapterAppointment { get; set; }
        public InArgument<int> serviceAccountId { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            log.Debug(string.Format("Entered for '{0}' and '{1}'", adapterAppointment, serviceAccountId));
            try
            {
                var myAdapterAppointment = adapterAppointment.Get(context);
                var myServiceAccountId = serviceAccountId.Get(context);
                log.Debug(string.Format("would call for '{0}'and '{1}'", myAdapterAppointment, myServiceAccountId));
                //AdapterAppointmentRepository.insertAppointmentAndAdapterAppointment(myAdapterAppointment, myServiceAccountId);
            }
            catch (Exception ex)
            {
                log.Fatal("failed", ex);
                throw;
            }
        }

    }}
