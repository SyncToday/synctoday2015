using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities.Appointments.Adapter
{
    public sealed class SaveAdapterAppointment : CodeActivity
      {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<Guid> internalId { get; set; }
        public InArgument<Models.AdapterAppointmentDTO> adapterAppointment { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            log.Debug(string.Format("Entered for '{0}' and '{1}'", adapterAppointment, internalId));
            try
            {
                var myAdapterAppointment = adapterAppointment.Get(context);
                var myInternalId = internalId.Get(context);
                log.Debug(string.Format("Got '{0}' and '{1}'", myAdapterAppointment, myInternalId));
                AdapterAppointmentRepository.Update(myInternalId, myAdapterAppointment);
            }
            catch (Exception ex)
            {
                log.Fatal("failed", ex);
                throw;
            }
        }

    }}
