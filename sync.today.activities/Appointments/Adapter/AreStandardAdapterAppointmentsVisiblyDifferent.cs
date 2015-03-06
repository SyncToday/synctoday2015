using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities.Appointments.Adapter
{
    public sealed class AreStandardAdapterAppointmentsVisiblyDifferent : CodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<Models.AdapterAppointmentDTO> adapterAppointment1 { get; set; }
        public InArgument<Models.AdapterAppointmentDTO> adapterAppointment2 { get; set; }
        public OutArgument<bool> result { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            log.Debug(string.Format("Entered for '{0}' and '{1}'", adapterAppointment1, adapterAppointment2));
            try
            {
                var myAdapterAppointment1 = adapterAppointment1.Get(context);
                var myAdapterAppointment2 = adapterAppointment2.Get(context);
                log.Debug(string.Format("would call for '{0}' and '{1}'", myAdapterAppointment1, myAdapterAppointment2));
                var myResult = AdapterAppointmentRepository.AreStandardAttrsVisiblyDifferent(myAdapterAppointment1, myAdapterAppointment2);
                result.Set(context, myResult);
            }
            catch (Exception ex)
            {
                log.Fatal("failed", ex);
                throw;
            }
        }

    }}
