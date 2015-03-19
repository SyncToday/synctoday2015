using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities.Consumers
{
    public sealed class GetConsumerByAdapterAppointment : CodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public InArgument<Models.AdapterAppointmentDTO> AdapterAppointment { get; set; }
        public OutArgument<Models.ConsumerDTO> Consumer { get; set; }
        protected override void Execute(CodeActivityContext context)
        {
            log.Debug(string.Format("Entered for '{0}' and '{1}'", AdapterAppointment, Consumer));
            try
            {
                var myAdapterAppointment = AdapterAppointment.Get(context);
                log.Debug(string.Format("Got for '{0}'", myAdapterAppointment));
                var consumer = AdapterAppointmentRepository.GetConsumerByAdapterAppointment(myAdapterAppointment);
                log.Debug(string.Format("Consumer is '{0}'", consumer));
                Consumer.Set(context, consumer.Value);
            }
            catch (Exception ex)
            {
                log.Fatal("failed", ex);
                throw;
            }
        }
    }
}
