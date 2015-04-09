using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sync.today.activities.Consumers
{
    public sealed class GetConsumerByAdapterAppointment : BaseCodeActivity
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger
    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public InArgument<Models.AdapterAppointmentDTO> AdapterAppointment { get; set; }
        public OutArgument<Models.ConsumerDTO> Consumer { get; set; }
        protected override void DoExecute(CodeActivityContext context)
        {
            devlog.Debug(string.Format("Entered for '{0}' and '{1}'", AdapterAppointment, Consumer));
            var myAdapterAppointment = AdapterAppointment.Get(context);
            devlog.Debug(string.Format("Got for '{0}'", myAdapterAppointment));
            var consumer = AdapterAppointmentRepository.GetConsumerByAdapterAppointment(myAdapterAppointment);
            devlog.Debug(string.Format("Consumer is '{0}'", consumer));
            Consumer.Set(context, consumer.Value);
        }
    }
}
