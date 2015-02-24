using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities.Appointments
{
    public sealed class GetAppointments : CodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public InArgument<Models.ConsumerDTO> consumer { get; set; }
        public OutArgument<Models.AppointmentDTO[]> appointments { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            log.Debug(string.Format("Entered for '{0}' and '{1}'", consumer, appointments));
            try
            {
                Models.ConsumerDTO myConsumer = consumer.Get(context);
                log.Debug(string.Format("Gor for '{0}'", myConsumer));
                var consumerItems = AppointmentRepository.ConsumerAppointments(myConsumer);
                List<Models.AppointmentDTO> resultItems = new List<Models.AppointmentDTO>(consumerItems);
                appointments.Set(context, consumerItems.ToArray());
            }
            catch (Exception ex)
            {
                log.Fatal("failed", ex);
                throw;
            }
        }

    }
}
